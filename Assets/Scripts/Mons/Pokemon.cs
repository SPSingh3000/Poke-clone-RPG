using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pokemon
{
    MonsDatabase _base;
    int level;

    public Pokemon(MonsDatabase pbase, int lvl)
    {
        _base = pbase;
        level = lvl;
    }
  
    public int MaxHP
    {
        get
        {
            return Mathf.FloorToInt((_base.MaxHP * level) / 100f) + 10;
        }
    }

    public int Attack
    {
        get 
        { 
            return Mathf.FloorToInt((_base.Atk * level) / 100f) + 5;
        }
    }

    public int Defense
    {
        get
        {
            return Mathf.FloorToInt((_base.Def * level) / 100f) + 5;
        }
    }

    public int SpAtk
    {
        get
        {
            return Mathf.FloorToInt((_base.SpAtk * level) / 100f) + 5;
        }
    }
    public int SpDef
    {
        get
        {
            return Mathf.FloorToInt((_base.SpDef * level) / 100f) + 5;
        }
    }

    public int Speed
    {
        get
        {
            return Mathf.FloorToInt((_base.Speed * level) / 100f) + 5;
        }
    }



}
