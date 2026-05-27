public abstract class Hero : Character
{
    public int SpecialSkillCooldown { get; set; } = 0;
    public int RemainingHeals { get; set; } = 2;

    protected Hero(string name, CharacterClass characterClass, int maxHp, int baseAttack) 
        : base(name, characterClass, maxHp, baseAttack, armor: 0) { }

    public void DecrementCooldown()
    {
        if (SpecialSkillCooldown > 0) SpecialSkillCooldown--;
    }
}