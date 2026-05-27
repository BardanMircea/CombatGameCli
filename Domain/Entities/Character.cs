public abstract class Character : IDamageable
{
    public string Name { get; }
    public CharacterClass Class { get; }
    public Health Health { get; }
    public int BaseAttack { get; protected set; }
    public int Armor { get; protected set; }

    protected Character(string name, CharacterClass characterClass, int maxHp, int baseAttack, int armor = 0)
    {
        Name = name;
        Class = characterClass;
        Health = new Health(maxHp);
        BaseAttack = baseAttack;
        Armor = armor;
    }

    public void TakeDamage(int amount) => Health.TakeDamage(amount);
    public bool IsDead => Health.IsDead;
}