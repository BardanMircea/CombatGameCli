// Domain/Entities/Enemy.cs
public class Enemy : Character
{
    public Enemy(string name, CharacterClass characterClass, int maxHp, int baseAttack, int armor = 0) 
        : base(name, characterClass, maxHp, baseAttack, armor) { }
}