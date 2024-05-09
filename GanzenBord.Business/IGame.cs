using Ganzenbord.Business.Player;

namespace GanzenBord.Business
{
    public interface IGame
    {
        IPlayer CreatePlayer(int playerNumber);

        bool DidPlayerMove(IPlayer player, int previousSpace);

        void EndGame();

        bool FirstTurn9Roll(IPlayer player);

        void GameLoop();

        void MultiplayerCreation();

        void PlayerMove(IPlayer player);

        void PlayerTurn(IPlayer player);

        bool PlayerWinCheck();

        bool PlayerWon(IPlayer player);

        void StartGame();
    }
}