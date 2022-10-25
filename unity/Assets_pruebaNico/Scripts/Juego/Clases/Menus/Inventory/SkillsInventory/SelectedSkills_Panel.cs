using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectedSkills_Panel : MonoBehaviour
{
    [SerializeField] Panel_SkillList SkillListPanel;
    SkillsInventory SkillsInventory;
    GameObject[] SlotList;

    //Setters
    public void Set_SkillsInventory(SkillsInventory SkillsInventory)
    {
        this.SkillsInventory = SkillsInventory;
    }

    //Particular voids
    public void Open()
    {
        gameObject.SetActive(true);

        //Obtener botones (GameObjects) y desactivarlos
        int SlotCount = gameObject.transform.childCount;
        this.SlotList = new GameObject[SlotCount];
        for (int i = 0; i < SlotCount; i++)
        {
            this.SlotList[i] = gameObject.transform.GetChild(i).gameObject;
            Button btn = SlotList[i].GetComponent<Button>();
            btn.interactable = false;

            Slot_SkillInventory Slot = SlotList[i].GetComponent<Slot_SkillInventory>();
            Slot.Set_SlotIndex(i);
            Slot.Set_SlotSkill(this.SkillsInventory.Get_SelectedSkills()[i]);
        }

    }
    public void Close()
    {
        gameObject.SetActive(false);

        //Obtener botones (GameObjects) y desactivarlos
        int SlotCount = gameObject.transform.childCount;
        this.SlotList = new GameObject[SlotCount];
        for (int i = 0; i < SlotCount; i++)
        {
            this.SlotList[i] = gameObject.transform.GetChild(i).gameObject;
            Button btn = SlotList[i].GetComponent<Button>();
            btn.onClick.RemoveAllListeners();
            btn.interactable = false;
        }
    }
    public void Activate_Skill_Selector()
    {
        Open();
        for (int i=0; i < SlotList.Length; i++)
        {
            this.SlotList[i] = gameObject.transform.GetChild(i).gameObject;
            Button btn = SlotList[i].GetComponent<Button>();
            btn.onClick.AddListener(SelectedSkill_Btn);
            btn.interactable = true;
        }
    }
    void SelectedSkill_Btn()
    {
        Active_Skill Pointer = SkillListPanel.Get_Pointer();
        if (Pointer != null)
        {
            GameObject ActualButton = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;
            ActualButton.GetComponent<Image>().sprite = Pointer.Get_SkillIcon();
            Slot_SkillInventory Slot = ActualButton.GetComponent<Slot_SkillInventory>();

            Slot.Set_SlotSkill(Pointer);
            this.SkillsInventory.Set_ActiveSkill(Pointer,Slot.Get_SlotIndex());
        }
        
        Close();
        Open();
    }
    
}
