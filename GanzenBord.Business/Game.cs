using Ganzenbord.Business.Dice;
using Ganzenbord.Business.Logger;
using Ganzenbord.Business.Player;
using GanzenBord.Business.Factories;
using GanzenBord.Business.Spaces;

namespace GanzenBord.Business
{
    public class Game : IGame
    {
        private ILogger logger;
        private IPlayerFactory playerFactory;
        private IDice dice;
        private IBoard board;
        private List<IPlayer> playerList;

        public Game(ILogger logger, IPlayerFactory playerFactory, IDice dice, IBoard board)
        {
            this.logger = logger;
            this.playerFactory = playerFactory;
            this.dice = dice;
            this.board = board;
            this.playerList = new List<IPlayer>();
        }

        public void StartGame()
        {
            logger.PrintMessage("|-=-| WELCOME TO GAME OF GOOSE |-=-|");
            logger.PrintMessage("");
        }

        public IPlayer CreatePlayer(int playerNumber)
        {
            logger.PrintMessage($"Please enter your name player {playerNumber}:");
            return playerFactory.Create(logger.ReadInput());
        }

        public void MultiplayerCreation()
        {
            logger.PrintMessage($"How many players will play the game?");
            int playerAmount = Convert.ToInt32(logger.ReadInput());
            logger.PrintMessage("");
            for (int i = 0; i < playerAmount; i++)
            {
                playerList.Add(CreatePlayer(i + 1));
                logger.PrintMessage("");
            }
        }

        public void EndGame()
        {
            logger.PrintMessage("Thanks for playing Game Of Goose!");
            logger.ReadInput();
        }

        public void PlayerTurn(IPlayer player)
        {
            int[] diceRoll = dice.Roll(2);
            player.lastRoll = diceRoll;

            PlayerMove(player);
        }

        public void PlayerMove(IPlayer player)
        {
            if (!FirstTurn9Roll(player))
            {
                if (player.CanMove && player.TurnsToSkip == 0)
                {
                    logger.PrintMessage($"{player.Name} rolled {player.lastRoll.Sum()}!");
                    player.MoveTo(player.CalculateDestination(player.lastRoll.Sum(), board.Spaces.Count - 1));
                    SpaceEffectChecker(player);
                }
                else if (player.TurnsToSkip > 0)
                {
                    player.TurnsToSkip--;
                    logger.PrintMessage($"{player.Name} skips 1 turn! {player.TurnsToSkip} turns remaining...");
                }
                else
                {
                    logger.PrintMessage($"{player.Name} is calling for help, but everyone is just ignoring him...");
                }
            }
            player.Direction = Direction.forwards;
        }

        private void SpaceEffectChecker(IPlayer player)
        {
            int currentSpace = player.CurrentSpace;
            board.Spaces[player.CurrentSpace].SpaceEffect(player);
            while (DidPlayerMove(player, currentSpace))
            {
                currentSpace = player.CurrentSpace;
                board.Spaces[player.CurrentSpace].SpaceEffect(player);
            }
        }

        public bool FirstTurn9Roll(IPlayer player)
        {
            bool firstTurn9Roll = false;

            if (player.CurrentSpace == 0)
            {
                if (player.lastRoll.Sum() == 9)
                {
                    if (player.lastRoll[0] == 4 || player.lastRoll[1] == 4)
                    {
                        logger.PrintMessage($"{player.Name} rolled {player.lastRoll.Sum()} with {player.lastRoll[0]} + {player.lastRoll[1]}!");
                        firstTurn9Roll = true;
                        player.MoveTo(26);
                        board.Spaces[player.CurrentSpace].SpaceEffect(player);
                    }
                    if (player.lastRoll[0] == 3 || player.lastRoll[1] == 3)
                    {
                        logger.PrintMessage($"{player.Name} rolled {player.lastRoll.Sum()} with {player.lastRoll[0]} + {player.lastRoll[1]}!");
                        firstTurn9Roll = true;
                        player.MoveTo(53);
                        board.Spaces[player.CurrentSpace].SpaceEffect(player);
                    }
                }
            }
            return firstTurn9Roll;
        }

        public void GameLoop()
        {
            while (!PlayerWinCheck())
            {
                foreach (IPlayer player in playerList)
                {
                    if (!PlayerWinCheck())
                    {
                        PlayerTurn(player);
                        logger.ReadInput();
                    }
                }
            }
        }

        public bool PlayerWon(IPlayer player)
        {
            bool playerWon = false;
            if (player.CurrentSpace == board.Spaces.Count - 1)
            {
                playerWon = true;
            }
            return playerWon;
        }

        public bool PlayerWinCheck()
        {
            bool playerWon = false;

            foreach (IPlayer player in playerList)
            {
                if (PlayerWon(player))
                {
                    playerWon = true;
                }
            }
            return playerWon;
        }

        public bool DidPlayerMove(IPlayer player, int previousSpace)
        {
            bool playerMoved = false;
            if (player.CurrentSpace != previousSpace)
            {
                playerMoved = true;
            }
            return playerMoved;
        }
    }
}
