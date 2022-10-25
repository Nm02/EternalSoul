using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SkillsInventory :MonoBehaviour
{
    //Crear lista de Habilidades Activas
    Active_Skill[] SelectedSkills=new Active_Skill[5];

    //Crear inventarios de habilidades
    [SerializeField] MagicSkill[] MagicSkillList;
    [SerializeField] PhysicalSkill[] PhysicalSkillList;
    [SerializeField] Holy_Skill[] HolySkillList;
    [SerializeField] Cursed_Skill[] CursedSkillList;


    


    //Setters
    public void Set_ActiveSkill(Active_Skill SelectedSkills, int SelectedSkillNumber)
    {
        this.SelectedSkills[SelectedSkillNumber] = SelectedSkills;
    }

    //Removers
    public void Remove_ChosenSkills(int SelectedSkillsNumber)
    {
        this.SelectedSkills[SelectedSkillsNumber]=null;
    }

    //Activates
    public void Activate_Skill(int SelectedSkillsNumber)
    {
        this.SelectedSkills[SelectedSkillsNumber].Use_Skill(gameObject);
    }

    //Geters
    public Active_Skill[] Get_SelectedSkills()
    {
        return this.SelectedSkills;
    }
    public MagicSkill[] Get_MagicSkillList()
    {
        return this.MagicSkillList;
    }
    public PhysicalSkill[] Get_PhysicalSkillList()
    {
        return this.PhysicalSkillList;
    }
    public Holy_Skill[] Get_HolySkillList()
    {
        return this.HolySkillList;
    }
    public Cursed_Skill[] Get_CursedSkillList()
    {
        return this.CursedSkillList;
    }
    public bool IsSelected(Active_Skill Skill)
    {
        
        bool IsSelected = false;
        for (int i = 0; i < SelectedSkills.Length; i++)
        {
            if (Skill == SelectedSkills[i])
            {
                IsSelected = true;
            }
        }
        return IsSelected;
    }


}
