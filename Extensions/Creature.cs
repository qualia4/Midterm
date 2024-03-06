using Core.Interfaces;

namespace Extensions;

public class Creature: ICreature
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }

    public event Action<string> Die;
    public int Attack { get; set; }

    public Creature(string name, int health, int attack)
    {
        this.Name = name;
        this.Health = health;
        this.Attack = attack;
    }

    public void ReceiveDamage(int damage)
    {
        this.Health = this.Health - damage;
        if (Health <= 0)
        {
            Die?.Invoke(this.Name);
        }
    }
}