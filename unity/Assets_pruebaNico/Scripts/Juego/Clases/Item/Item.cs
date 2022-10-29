using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    Dictionary<string, int> BonusStatsEfects = new Dictionary<string, int>()
    {
        {"Health",0 },{"PhysycalDamage",0},{"MagicalDamage",0},{"HolyDamage",0}
    };

    //Setters
    public void Set_BonusStatsEfects(string Key, int Value)
    {
        this.BonusStatsEfects[Key] = Value;
    }

    //Getters
    public Dictionary<string, int> Get_BonusStatsEfects()
    {
        return this.BonusStatsEfects;
    }



}
