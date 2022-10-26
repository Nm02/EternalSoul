using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Navigatin_Buttons : MonoBehaviour
{
    GameObject[] Buttons;
    ItemInventory_Menu ItemInventoryMenuPanel;
    SkillsInventoryMenu_Panel SkillInventoryMenuPanel;
    PlayerMenu_Panel PlayerMenuPanel;


    //Setters
    public void Set_ItemInventoryMenuPanel(ItemInventory_Menu ItemInventoryMenuPanel)
    {
        this.ItemInventoryMenuPanel = ItemInventoryMenuPanel;
    }
    public void Set_SkillInventoryMenuPanel(SkillsInventoryMenu_Panel SkillInventoryMenuPanel)
    {
        this.SkillInventoryMenuPanel = SkillInventoryMenuPanel;
    }
    public void Set_PlayerMenuPanel(PlayerMenu_Panel PlayerMenuPanel)
    {
        this.PlayerMenuPanel = PlayerMenuPanel;
    }

    //Particular voids
    public void Open()
    {
        gameObject.SetActive(true);
        
        this.Buttons =new GameObject[gameObject.transform.childCount];
        for (int i = 0; i < Buttons.Length; i++)
        {
            this.Buttons[i] = gameObject.transform.GetChild(i).gameObject;
        }
        Button btn;

        btn = Buttons[0].GetComponent<Button>();
        btn.onClick.AddListener(Btn_ItemInventory);

        btn = Buttons[1].GetComponent<Button>();
        btn.onClick.AddListener(Btn_SkillInventory);

        btn = Buttons[2].GetComponent<Button>();
        btn.onClick.AddListener(Btn_PlayerMenu);


    }
    
    public void close()
    {
        gameObject.SetActive(false);
    }

    void Btn_ItemInventory()
    {
        this.ItemInventoryMenuPanel.Open();
        this.SkillInventoryMenuPanel.Close();
        this.PlayerMenuPanel.Close();
    }
    void Btn_SkillInventory()
    {
        this.ItemInventoryMenuPanel.Close();
        this.SkillInventoryMenuPanel.Open();
        this.PlayerMenuPanel.Close();
    }
    void Btn_PlayerMenu()
    {
        this.ItemInventoryMenuPanel.Close();
        this.SkillInventoryMenuPanel.Close();
        this.PlayerMenuPanel.Open();
    }

}
