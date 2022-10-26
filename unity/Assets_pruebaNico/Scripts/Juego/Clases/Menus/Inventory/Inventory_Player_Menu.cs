using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory_Player_Menu : MonoBehaviour
{
    [SerializeField] Menu_Navigatin_Buttons MenuNavigatinButtons;
    [SerializeField] ItemInventory_Menu ItemInventoryMenuPanel;
    [SerializeField] SkillsInventoryMenu_Panel SkillInventoryMenuPanel;
    [SerializeField] PlayerMenu_Panel PlayerMenuPanel;

    [SerializeField] SkillsInventory SkillsInventory;

    public void Start()
    {
        Open();
    }


    //Particular Voids
    public void Open()
    {
        gameObject.SetActive(true);



        MenuNavigatinButtons.Set_ItemInventoryMenuPanel(ItemInventoryMenuPanel);
        MenuNavigatinButtons.Set_SkillInventoryMenuPanel(SkillInventoryMenuPanel);
        MenuNavigatinButtons.Set_PlayerMenuPanel(PlayerMenuPanel);


        SkillInventoryMenuPanel.Set_SkillsInventory(SkillsInventory);


        MenuNavigatinButtons.Open();
        ItemInventoryMenuPanel.Open();
        SkillInventoryMenuPanel.Close();
        PlayerMenuPanel.Close();

    }
    public void Close()
    {
        gameObject.SetActive(false);

        MenuNavigatinButtons.close();
        ItemInventoryMenuPanel.Close();
        SkillInventoryMenuPanel.Close();
        PlayerMenuPanel.Close();

    }

}
