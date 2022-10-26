using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot_SkillInventory : MonoBehaviour
{
    [SerializeField] Sprite DeafaultIcon;
    private Active_Skill Skill;
    private string SkillDescription;
    private Image SlotImage;
    int SlotIndex;

    //Setters
    public void Set_SlotIndex(int SlotIndex)
    {
        this.SlotIndex = SlotIndex;
    }
    public void Set_SlotSkill(Active_Skill NewSkill =null)
    {
        if (NewSkill != null) 
        {
            this.Skill = NewSkill;
            this.SkillDescription=NewSkill.Get_SkillDescription();

            Set_SkillIcon(Skill.Get_SkillIcon());
        }
        else
        {
            this.Skill = null;
            //this.SlotImage.sprite = this.DeafaultIcon;
            Set_SlotDeafaultIcon();

        }
    }
    void Set_SlotDeafaultIcon()
    {
        this.SlotImage = GetComponent<Image>();
        this.SlotImage.sprite = this.DeafaultIcon;
    }
    void Set_SkillIcon(Sprite Icon)
    {
        this.SlotImage = GetComponent<Image>();
        this.SlotImage.sprite = Icon;
    }
    

    //Getters
    public Active_Skill Get_Skill()
    {
        return this.Skill;
    }
    public int Get_SlotIndex()
    {
        return this.SlotIndex;
    }

}
