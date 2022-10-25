using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public abstract class Active_Skill : Skill 
{
    
    [SerializeField]bool IsLocked=true;

    /*
    public Skill(string SkillName, bool Is_Locked=true)
    {
        this.SkillName = SkillName;
        this.Is_Locked = Is_Locked;
    }
    */


    //Getters
    public bool Get_IsLocked()
    {
        return this.IsLocked;
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
