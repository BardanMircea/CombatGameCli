public class Rogue : Hero
{
    public const int MaxHp = 90;
    public const int Attack = 14;

    public Rogue(string name) : base(name, CharacterClass.Rogue, MaxHp, Attack) { }
}