public interface IDamageable
{
    string Name { get; }
    Health Health { get; }
    int Armor { get; }
    bool IsDead { get; }
    void TakeDamage(int amount);
}