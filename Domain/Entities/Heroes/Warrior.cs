public class Warrior : Hero
{
    public const int MaxHp = 120;
    public const int Attack = 18;
    
    public Warrior(string name) : base(name, CharacterClass.Warrior, MaxHp, Attack) { }
}