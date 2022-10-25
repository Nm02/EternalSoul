using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSkillTeste : MonoBehaviour
{
    [SerializeField] Active_Skill skill;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            skill.Use_Skill(gameObject);
        }
        
    }
}
