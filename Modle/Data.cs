using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Êý¾Ý
/// </summary>
public class Data
{
    private int hp;
    private int maxHp;

    public int HP
    {
        get => hp;
        set
        {
            if (value > 0)
            {
                hp -= value;
            }
        }
    }
    public int MaxHp
    {
        get => maxHp;
        set => maxHp = value;
    }

    public Data(int maxHp)
    {
        this.hp = this.maxHp = maxHp;
    }
}

