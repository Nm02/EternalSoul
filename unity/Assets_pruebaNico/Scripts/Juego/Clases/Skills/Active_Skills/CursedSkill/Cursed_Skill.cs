using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Cursed_Skill : Active_Skill
{
    [SerializeField] int HealthCost;

    //Setters
    public void Set_HealthCost(int HealthCost)
    {
        this.HealthCost = HealthCost;
    }

    //Getters
    public int Get_HealthCost()
    {
        return this.HealthCost;
    }

}
