namespace Ganzenbord.Business.Dice
{
    public interface IDice
    {
        int Faces { get; set; }

        int[] Roll(int amount);
    }
}