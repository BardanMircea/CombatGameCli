public class Mage : Hero
{
    public const int MaxHp = 80;
    public const int Attack = 12;

    public Mage(string name) : base(name, CharacterClass.Mage, MaxHp, Attack) { }
}