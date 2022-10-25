using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public abstract class MagicSkill : Active_Skill
{
    [SerializeField]int ManaCost;
    /*
    public MagicSkill(string SkillName, int ManaCost) : base(SkillName)
    {
        this.ManaCost = ManaCost;
    }
    */

    //Setters
    public void Set_ManaCost(int ManaCost)
    {
        this.ManaCost = ManaCost;
    }

    //Getters
    public int Get_ManaCost()
    {
        return this.ManaCost;
    }

}

