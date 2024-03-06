using Core.Interfaces;

namespace Extensions;

public class GameField: IGameField
{
    public List<ICreature> Creatures { get; set; }
    public IPlayer FirstPlayer { get; set;}
    public IPlayer SecondPlayer { get; set; }
    public bool FirstPlayerStep { get; set; }

    public void Initialize()
    {
        Creatures = new List<ICreature>();
    }

    public void AddCreature(ICreature creature)
    {
        Creatures.Add(creature);
        if (FirstPlayerStep)
        {
            FirstPlayer.AddCreature(creature.Id);
            return;
        }
        SecondPlayer.AddCreature(creature.Id);

    }
}