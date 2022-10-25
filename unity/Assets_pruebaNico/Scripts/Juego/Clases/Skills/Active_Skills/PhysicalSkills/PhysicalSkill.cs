using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PhysicalSkill : Active_Skill
{

    [SerializeField] int StaminaCost;

    //Setters
    public void Set_StaminaCost(int StaminaCost)
    {
        this.StaminaCost = StaminaCost;
    }

    //Getters
    public int Get_StaminaCost()
    {
        return this.StaminaCost;
    }

}
