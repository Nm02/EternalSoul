using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Skill : MonoBehaviour 
{
    [SerializeField] Sprite SkillIcon;
    [SerializeField]string SkillName;
    [SerializeField]string SkillDescription;
    bool IsLocked=true;

    /*
    public Skill(string SkillName, bool Is_Locked=true)
    {
        this.SkillName = SkillName;
        this.Is_Locked = Is_Locked;
    }
    */
    //Setters
    public void Set_SkillName(string SkillName)
    {
        this.SkillName=SkillName;
    }

    //Getters

    public string Get_SkillName()
    {
        return this.SkillName;
    }
    public Sprite Get_SkillIcon() 
    {
        return this.SkillIcon;
    }
    public string Get_SkillDescription()
    {
        return this.SkillDescription;
    }

    //Unlock Skill
    public void Unlock_Skill()
    {
        this.IsLocked = false;
    }

    //Lock Skill
    public void Lock_Skill()
    {
        this.IsLocked=true;
    }

    //Abstracto Use_Skill
    public  abstract void Use_Skill(GameObject Player);
    

}
