using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillsInventoryMenu_Panel : MonoBehaviour
{

    [SerializeField] SkillInventoryControlPanel SkillInventoryControlPanel;
    [SerializeField] SelectedSkills_Panel SelectedSkills_Panel;
    [SerializeField] Panel_SkillList Panel_SkillList;
    SkillsInventory SkillsInventory;



    //Setters
    public void Set_SkillsInventory(SkillsInventory SkillsInventory)
    {
        this.SkillsInventory = SkillsInventory;
    }


    //Particular Voids
    public void Open()
    {
        gameObject.SetActive(true);

        this.SkillInventoryControlPanel.Set_SkillInventory(this.SkillsInventory);
        this.SelectedSkills_Panel.Set_SkillsInventory(this.SkillsInventory);
        this.Panel_SkillList.Set_SkillsInventory(this.SkillsInventory);


        this.SkillInventoryControlPanel.Open();
        this.SelectedSkills_Panel.Open();




    }
    public void Close()
    {
        gameObject.SetActive(false);

        SkillInventoryControlPanel.Close();
        SelectedSkills_Panel.Close();
        Panel_SkillList.Close();
    }



}
