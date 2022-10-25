using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Skill : MonoBehaviour
{
    [SerializeField] Sprite SkillIcon;
    [SerializeField] string SkillName;
    [SerializeField] string SkillDescription;

    //Setters
    public void Set_SkillIcon(Sprite SkillIcon)
    {
        this.SkillIcon = SkillIcon;
    }
    public void Set_SkillName(string SkillName)
    {
        this.SkillName = SkillName;
    }
    public void Set_SkillDescription(string SkillDescription)
    {
        this.SkillDescription = SkillDescription;
    }
    //Getters
    public Sprite Get_SkillIcon()
    {
        return this.SkillIcon;
    }

    public string Get_SkillName()
    {
        return this.SkillName;
    }
    
    public string Get_SkillDescription()
    {
        return this.SkillDescription;
    }
}
