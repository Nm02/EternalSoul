using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slot : MonoBehaviour
{
    [SerializeField] Sprite DeafaultIcon;
    private Skill Skill;
    private string SkillDescription;
    public Image SlotImage;

    public void Start()
    {
        this.SlotImage = GetComponent<Image>();
    }
    public void SetSlotSkill(Skill NewSkill=null)
    {
        if (NewSkill != null) 
        {
            this.Skill = NewSkill;
            this.SkillDescription=NewSkill.Get_SkillDescription();

            this.SlotImage.sprite = Skill.Get_SkillIcon();
        }
        else
        {
            this.Skill = null;
            this.SlotImage.sprite = this.DeafaultIcon;
        }
    }

}
