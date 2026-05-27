public class Health
{
    public int Current { get; private set; }
    public int Max { get; }

    public Health(int maxHp)
    {
        Max = maxHp;
        Current = maxHp;
    }

    public void TakeDamage(int amount)
    {
        if (amount < 0) return;
        Current = Math.Max(0, Current - amount);
    }

    public void Heal(int amount)
    {
        if (amount < 0) return;
        Current = Math.Min(Max, Current + amount);
    }

    public bool IsDead => Current <= 0;
}