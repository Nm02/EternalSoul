using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillsInventory :MonoBehaviour
{




    //Crear lista de Habilidades Activas
    Skill[] ChosenSkills;
    [SerializeField]MagicSkill[] MagicSkillList;
    [SerializeField]GameObject SkillListPanel;
    



    //constructor

    private void Start()
    {

    }

    //Setters
    public void Set_ChosenSkills(int ChosenSkillsNumber, Skill ChosenSkills)
    {
        this.ChosenSkills[ChosenSkillsNumber]= ChosenSkills;
    }

    //Removers
    public void Remove_ChosenSkills(int ChosenSkillsNumber)
    {
        this.ChosenSkills[ChosenSkillsNumber]=null;
    }

    //Activates
    public void Activate_Skill(int ChosenSkillsNumber)
    {
        this.ChosenSkills[ChosenSkillsNumber].Use_Skill(gameObject);
    }
    
}
