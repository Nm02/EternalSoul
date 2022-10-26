using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillTeste : MonoBehaviour
{
    [SerializeField] SkillsInventory SkillsInventory;
    [SerializeField] GameObject SkillsInventoryMenu;
    bool ActiveMenu=true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            SkillsInventory.Activate_Skill(0,gameObject);
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            SkillsInventory.Activate_Skill(1, gameObject);
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            SkillsInventory.Activate_Skill(2, gameObject);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SkillsInventory.Activate_Skill(3, gameObject);
        }
        if (Input.GetKeyDown(KeyCode.T))
        {
            SkillsInventory.Activate_Skill(4, gameObject);
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            SkillsInventoryMenu.SetActive(!ActiveMenu);
            ActiveMenu = !ActiveMenu;
        }

    }
}
