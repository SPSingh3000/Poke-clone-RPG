using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Pokemon", menuName = "Create new Mon")] 
public class MonsDatabase : ScriptableObject
{
    [SerializeField] string name;

    [TextArea]
    [SerializeField] string description;

    [SerializeField] Sprite frontSprite;
    [SerializeField] Sprite backSprite;

    [SerializeField] PokemonType type1;
    [SerializeField] PokemonType type2;

    [SerializeField] int maxHP;
    [SerializeField] int atk;
    [SerializeField] int def;
    [SerializeField] int spAtk;
    [SerializeField] int spDef;
    [SerializeField] int speed;

    
    public string Name
    {
        get { return name; }
    }

    public string Description
    {
        get { return description; }
    }

    public Sprite FrontSprite
    {
        get { return frontSprite;}
    }

    public Sprite BackSprite
    {
        get { return backSprite;}
    }

    public PokemonType Type1
    {
        get { return type1; }
    }

    public PokemonType Type2
    {
       get { return type2; }
    }

    public int MaxHP
    {
        get { return maxHP; }
    }

    public int Atk
    {
        get { return atk; }
    }

    public int Def
    {
        get { return def; }
    }

    public int SpAtk
    {
        get { return spAtk; }
    }

    public int SpDef
    {
        get { return spDef; }
    }

    public int Speed
    {
        get { return speed; }
    }
}

public enum PokemonType
{
    None,
    Normal,
    Fire,
    Water,
    Grass,
    Flying,
    Fighting,
    Poison,
    Electric,
    Ground,
    Rock,
    Psychic,
    Ice,
    Bug,
    Ghost,
    Steel,
    Dragon,
    Dark,
    Fairy
}
