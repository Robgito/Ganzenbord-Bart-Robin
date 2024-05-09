namespace Ganzenbord.Business.Dice
{
    public class Dice : IDice
    {
        public int Faces { get; set; }

        public Dice(int faces = 6)
        {
            this.Faces = faces;
        }

        public int[] Roll(int amount)
        {
            Random random = new Random();
            int[] result = new int[amount];

            for (int i = 0; i < amount; i++)
            {
                result[i] = random.Next(1, this.Faces + 1);
            }

            return result;
        }
    }
}