namespace Core.Interfaces;

public interface IGameField
{
    public List<ICreature> Creatures { get; set; }
    public IPlayer FirstPlayer { get; set; }
    public IPlayer SecondPlayer { get; set; }

    public bool FirstPlayerStep { get; set; }

    public void AddCreature(ICreature creature);
    public void Initialize();
}