namespace Core.Interfaces;

public interface ISpell: IIdentifiable
{
    public int Id { get; }
    public void Cast();
}