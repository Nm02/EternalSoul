using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SkillInventoryControlPanel : MonoBehaviour
{
    [SerializeField] Panel_SkillList PanelSkillList;

    [SerializeField] SelectedSkills_Panel PanelSelectedSkill;

    [SerializeField] SkillsInventory SkillInventory;

    GameObject MagicSkillInventoryBtn;
    GameObject PhysicalSkillInventoryBtn;
    GameObject HolySkillInventoryBtn;
    GameObject CursedSkillInventoryBtn;
    GameObject PassiveSkillInvetoryBtn;


    private void Start()
    {
        Open();
    }



    //Particular voids 
    public void Open()
    {
        gameObject.SetActive(true);

        this.PanelSkillList.Set_SkillsInventory(this.SkillInventory);
        this.PanelSkillList.Close();
        
        this.PanelSelectedSkill.Set_SkillsInventory(this.SkillInventory);
        this.PanelSelectedSkill.Open();

        //Obtiene los botones y les asigna sus respectivas funciones
        Button btn;

        this.MagicSkillInventoryBtn = gameObject.transform.GetChild(0).gameObject;
        btn = MagicSkillInventoryBtn.GetComponent<Button>();
        btn.onClick.AddListener(MagicSkillInventoryBtn_OnClick);

        this.PhysicalSkillInventoryBtn = gameObject.transform.GetChild(1).gameObject;
        btn = PhysicalSkillInventoryBtn.GetComponent<Button>();
        btn.onClick.AddListener(PhysicalSkillInventoryBtn_OnClick);

        this.HolySkillInventoryBtn = gameObject.transform.GetChild(2).gameObject;
        btn = HolySkillInventoryBtn.GetComponent<Button>();
        btn.onClick.AddListener(HolySkillInventoryBtn_OnClick);

        this.CursedSkillInventoryBtn = gameObject.transform.GetChild(3).gameObject;
        btn = CursedSkillInventoryBtn.GetComponent<Button>();
        btn.onClick.AddListener(CursedSkillInventoryBtn_OnClick);

        this.PassiveSkillInvetoryBtn = gameObject.transform.GetChild(4).gameObject;
        btn = PassiveSkillInvetoryBtn.GetComponent<Button>();
        btn.onClick.AddListener(PassiveSkillInvetoryBtn_OnClick);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }
    void MagicSkillInventoryBtn_OnClick()
    {
        if (this.PanelSkillList.Get_OpenPanel() == "MagicSkillInventory")
        {
            this.PanelSelectedSkill.Open();
            this.PanelSkillList.Close();
        }
        else
        {
            this.PanelSelectedSkill.Close();
            this.PanelSkillList.Close();
            this.PanelSkillList.Open(SkillInventory.Get_MagicSkillList(), "MagicSkillInventory");
        }
        
    }
    void PhysicalSkillInventoryBtn_OnClick()
    {
        if (this.PanelSkillList.Get_OpenPanel() == "PhysicalSkillInventory")
        {
            this.PanelSelectedSkill.Open();
            this.PanelSkillList.Close();
        }
        else
        {
            this.PanelSelectedSkill.Close();
            this.PanelSkillList.Close();
            this.PanelSkillList.Open(SkillInventory.Get_PhysicalSkillList(), "PhysicalSkillInventory");
        }
    }
    void HolySkillInventoryBtn_OnClick()
    {
        if (this.PanelSkillList.Get_OpenPanel() == "HolySkillInventory")
        {
            this.PanelSelectedSkill.Open();
            this.PanelSkillList.Close();
        }
        else
        {
            this.PanelSelectedSkill.Close();
            this.PanelSkillList.Close();
            this.PanelSkillList.Open(SkillInventory.Get_HolySkillList(), "HolySkillInventory");
        }
    }
    void CursedSkillInventoryBtn_OnClick()
    {
        if (this.PanelSkillList.Get_OpenPanel() == "CursedSkillInventory")
        {
            this.PanelSelectedSkill.Open();
            this.PanelSkillList.Close();
        }
        else
        {
            this.PanelSelectedSkill.Close();
            this.PanelSkillList.Close();
            this.PanelSkillList.Open(SkillInventory.Get_CursedSkillList(),"CursedSkillInventory");
        }
    }
    void PassiveSkillInvetoryBtn_OnClick()
    {
        if (this.PanelSkillList.Get_OpenPanel() != "")
        {
            this.PanelSkillList.Close();
            print("panel aun no creado");
        }
        else
        {
            this.PanelSelectedSkill.Close();
            this.PanelSkillList.Close();
            print("panel aun no creado");
        }
    }

}
