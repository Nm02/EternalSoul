using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillContainer : MonoBehaviour
{
    [SerializeField]Skill SelectedSkill;


    //Setters
    public void Set_Skill(Skill SelectedSkill = null)
    {
        this.SelectedSkill = SelectedSkill;
    }

    //Active
    public void Activate_Skill(GameObject player)
    {
        if (SelectedSkill != null)
        {
            SelectedSkill.Use_Skill(player);
        }
        
    }




}
