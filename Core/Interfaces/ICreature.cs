namespace Core.Interfaces;

public interface ICreature: IIdentifiable
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Health { get; set; }
    public int Attack { get; set; }
    public event Action<string> Die;
    public void ReceiveDamage(int damage);
}