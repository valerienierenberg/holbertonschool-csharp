using System;

/// <summary> class Player </summary>
class Player
{
    /// <summary> public property name </summary>
    private string name { get; set; }

    /// <summary> public property maxHp </summary>
    private float maxHp { get; set; }

    /// <summary> public property hp </summary>
    private float hp { get; set; }

    /// <summary> public property status </summary>
    private string status { get; set; }

    /// <summary> public EventHandler<CurrentHPArgs/> HPCheck </summary>
    public EventHandler<CurrentHPArgs> HPCheck;

    /// <summary> public constructor Player </summary>
    public Player(string name = "Player", float maxHp = 100f)
    {
        if (maxHp <= 0f)
        {
            this.maxHp = 100f;
            Console.WriteLine("maxHp must be greater than 0. maxHp set to 100f by default.");
        }
        else
        {
            this.maxHp = maxHp;
        }
        this.name = name;
        this.hp = this.maxHp;
        this.status = $"{this.name} is ready to go!";
        HPCheck += CheckStatus;
    }

    /// <summary> public method PrintHealth() </summary>
    public void PrintHealth()
    {
        Console.WriteLine($"{this.name} has {this.hp} / {this.maxHp} health");
    }

    /// <summary> delegate CalculateHealth </summary>
    delegate void CalculateHealth(float health);

    /// <summary> public method TakeDamage() </summary>
    public void TakeDamage(float damage)
    {
        if (damage < 0f)
        {
            damage = 0f;
            Console.WriteLine($"{this.name} takes 0 damage!");
        }
        else
        {
            Console.WriteLine($"{this.name} takes {damage} damage!");
        }
        this.hp -= damage;
        ValidateHP(this.hp);
    }

    /// <summary> public method HealDamage() </summary>
    public void HealDamage(float heal)
    {
        if (heal < 0f)
        {
            heal = 0f;
            Console.WriteLine($"{this.name} heals 0 HP!");
        }
        else
        {
            Console.WriteLine($"{this.name} heals {heal} HP!");
        }
        this.hp += heal;
        ValidateHP(this.hp);
    }

    /// <summary> public method ValidateHP() </summary>
    public void ValidateHP(float newHp)
    {
        if (newHp < 0f)
        {
            this.hp = 0f;
        }
        else if (newHp > this.maxHp)
        {
            this.hp = maxHp;
        }
        else
        {
            this.hp = newHp;
        }
        HPCheck(this, new CurrentHPArgs(this.hp));
    }

    /// <summary> public method ApplyModifier </summary>
    public float ApplyModifier(float baseValue, Modifier modifier)
    {
        if (modifier == Modifier.Strong)
        {
            return baseValue * 1.5f;
        }
        else if (modifier == Modifier.Weak)
        {
            return baseValue / 2f;
        }
        else
        {
            return baseValue;
        }
    }

    /// <summary> private method CheckStatus() </summary>
    private void CheckStatus(object sender, CurrentHPArgs e)
    {
        if (e.currentHp == this.maxHp)
        {
            this.status = $"{this.name} is in perfect health!";
        }
        else if (e.currentHp >= (this.maxHp / 2))
        {
            this.status = $"{this.name} is doing well!";
        }
        else if (e.currentHp >= (this.maxHp / 4))
        {
            this.status = $"{this.name} isn't doing too great...";
        }
        else if (e.currentHp > 0)
        {
            this.status = $"{this.name} needs help!";
        }
        else
        {
            this.status = $"{this.name} is knocked out!";
        }
        Console.WriteLine(this.status);
    }
}

/// <summary> enum Modifier </summary>
enum Modifier
{
    Weak,
    Base,
    Strong
}
/// <summary> delegate CalculateModifier </summary>
delegate float CalculateModifier(float baseValue, Modifier modifier);

/// <summary> class CurrentHPArgs </summary>
class CurrentHPArgs : EventArgs
{
    /// <summary> public property currentHP </summary>
       public readonly float currentHp;
    
    /// <summary> public constructor CurrentHPArgs </summary>
    public CurrentHPArgs(float newHP)
    {
        this.currentHp = newHP;
    }
}
