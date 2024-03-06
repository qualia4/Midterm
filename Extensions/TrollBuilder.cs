using Core.Interfaces;

namespace Extensions;

public class TrollBuilder: ICreatureBuilder
{
    public ICreature Create()
    {
        Creature troll = new Creature("troll", 10, 2);
        return troll;
    }
}