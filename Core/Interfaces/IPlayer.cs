namespace Core.Interfaces;

public interface IPlayer
{
    public List<int> Creatures { get; }
    public void AddCreature(int id);

}