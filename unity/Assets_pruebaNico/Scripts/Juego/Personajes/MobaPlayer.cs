using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class MobaPlayer : MonoBehaviour
{
    NavMeshAgent Agent;
    [HideInInspector]
    public float Stamina = 0;
    [Header("Character options")]
    public int Walkspeed = 5;
    public int RunSpeed = 8;
    public float DecreaseseStaminaSpeed = 1;
    public float IncreaseStaminaSpeed = 1;

    public float MaxStamina;
    public Slider StaminaBar;
    public GameObject weapon;

    [Header("opciones de menu.")]
    public MenusDeJuego Menus;


    void Start()
    {
        StaminaBar.maxValue = MaxStamina;
        Agent = GetComponent<NavMeshAgent>();
        Agent.speed = Walkspeed;
        Stamina = MaxStamina;
    }
    void Update()
    {
        
        movement();
        stamina();

    }
    void movement()
    {
        if (Input.GetKey(KeyCode.LeftShift) && Stamina >= 0)
        {
            Agent.speed = RunSpeed;
            decrasestamina();
        }
        else
        {
            Agent.speed = Walkspeed;
            increasestamina();
        }
        if (Input.GetMouseButtonDown(0))
        { 
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            if (Physics.Raycast(ray, out hit, Mathf.Infinity) && !Menus.MenuAbierto)////
            {

                Agent.SetDestination(hit.point);
            }
            
        }

    }
    void stamina()
    {
        StaminaBar.value = Stamina;
        if (Stamina > MaxStamina)
        {
            Stamina = MaxStamina;
        }
    }
    void decrasestamina()
    {
        if (Stamina > 0&& Agent.remainingDistance > 0)
        {
            Stamina -= DecreaseseStaminaSpeed * Time.deltaTime;
        }
        if (Stamina<=0)
        {
            Stamina = 0;
            Agent.speed = Walkspeed;
        }
    }
    void increasestamina()
    {
        if (Stamina <= MaxStamina)
        {
            Stamina += IncreaseStaminaSpeed * Time.deltaTime;
        }


    }

}
