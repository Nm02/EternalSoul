using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_SkillList : MonoBehaviour
{
    GameObject[] SlotList;
    int SlotCount;
    Active_Skill Pointer;

    [SerializeField] SelectedSkills_Panel PanelSelectedSkills;

    string OpenPanel;

    SkillsInventory SkillsInventory;


    //Setters
    public void Set_Pointer(Active_Skill Pointer=null)
    {
        this.Pointer = Pointer;
        
    }
    public void Set_SkillsInventory(SkillsInventory SkillsInventory)
    {
        this.SkillsInventory = SkillsInventory;
    }

    //Getters
    public Active_Skill Get_Pointer()
    {
        return this.Pointer;
    }
    public string Get_OpenPanel()
    {
        return this.OpenPanel;
    }


    //Particular voids 
    public void Open(Active_Skill[] SkillInventory, string OpenPanel)
    {
        gameObject.SetActive(true);

        Set_Pointer();

        this.OpenPanel = OpenPanel;

        this.SlotCount = gameObject.transform.childCount;
        this.SlotList = new GameObject[SlotCount];
        int i = 0;
        for (i = 0; i < SlotCount; i++)
        {
            this.SlotList[i] = gameObject.transform.GetChild(i).gameObject;
        }

        i = 0;
        int j = 0;
        if (SkillInventory.Length > 0)
        {
            while (i < this.SlotCount && j < SkillInventory.Length)
            {
                if (!SkillInventory[j].Get_IsLocked())
                {
                    Slot_SkillInventory Slot = this.SlotList[j].GetComponent<Slot_SkillInventory>();
                    Slot.Set_SlotIndex(i);
                    Slot.Set_SlotSkill(SkillInventory[j]);

                    //Agrega un evento OnClick a un boton
                    Button btn = SlotList[i].GetComponent<Button>();
                    btn.onClick.AddListener(Ocuped_SlotBtn_OnClick);
                    i++;
                }
                j++;
            }
        }
        
        while (i < this.SlotCount)
        {
            Slot_SkillInventory Slot = this.SlotList[i].GetComponent<Slot_SkillInventory>();
            Slot.Set_SlotSkill();
            Slot.Set_SlotIndex(i);
            Button btn = SlotList[i].GetComponent<Button>();
            btn.onClick.AddListener(Empty_SlotBtn_OnClick);
            i++;
        }
    }

    public void Close()
    {
        for (int i = 0; i < SlotCount; i++)
        {
            Slot_SkillInventory Slot = this.SlotList[i].GetComponent<Slot_SkillInventory>();
            Slot.Set_SlotSkill();

            //Elimina los eventos OnClick de los botones
            Button btn = SlotList[i].GetComponent<Button>();
            btn.onClick.RemoveAllListeners();
        }
        this.OpenPanel = "";
        gameObject.SetActive(false);
        
    }

    void Ocuped_SlotBtn_OnClick()
    {
        GameObject ActualButton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
        Slot_SkillInventory Slot = ActualButton.GetComponent<Slot_SkillInventory>();

        if (!this.SkillsInventory.IsSelected(Slot.Get_Skill()))
        {
            Set_Pointer(Slot.Get_Skill());
            Close();
            this.PanelSelectedSkills.Open();
            this.PanelSelectedSkills.Activate_Skill_Selector();
        }
        else
        {
            print("Habilidad ya seleccionada");
        }
        

        

        

    }
    void Empty_SlotBtn_OnClick()
    {
        print("No hay nada en ese boton");
    }
}
