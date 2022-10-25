using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Holy_Skill : Active_Skill
{
    [SerializeField] int HolyEnergyCost;


    //Setters
    public void Set_HolyEnergyCost(int HolyEnergyCost)
    {
        this.HolyEnergyCost = HolyEnergyCost;
    }

    //Getters
    public int Get_HolyEnergyCost()
    {
        return this.HolyEnergyCost;
    }

}
