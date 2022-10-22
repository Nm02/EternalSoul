using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{

    [SerializeField] int PhysicalDamage=0;
    [SerializeField] int MagicDamage=0;
    [SerializeField] int HolyDamage=0;

    [SerializeField] int HealthPoints=1;

    [SerializeField] int ManaPoints = 0;
    [SerializeField] int StaminaPoints = 0;
    [SerializeField] int HolyEnergyPoints = 0;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    public bool Is_Alive()
    {
        return HealthPoints>0;
    }

    //Get Stats
    public int Get_PhysicalDamage()
    {
        return PhysicalDamage;
    }
    public int Get_MagicDamage()
    {
        return MagicDamage;
    }
    public int Get_HolyDamage()
    {
        return HolyDamage;
    }
    public int Get_HealthPoints()
    {
        return HealthPoints;
    }
    public int Get_ManaPoints()
    {
        return ManaPoints;
    }
    public int Get_StaminaPoints()
    {
        return StaminaPoints;
    }
    public int Get_HolyEnergyPoints()
    {
        return HolyEnergyPoints;
    }


    //Set Stats
    public void Set_PhysicalDamage(int PhysicalDamage)
    {
        this.PhysicalDamage = PhysicalDamage;
    }
    public void Set_MagicDamage(int MagicDamage)
    {
        this.MagicDamage = MagicDamage;
    }
    public void Set_HolyDamage(int HolyDamage)
    {
        this.HolyDamage = HolyDamage;
    }
    public void Set_HealthPoints(int Health)
    {
        this.HealthPoints = Health;
    }
    public void Set_ManaPoints(int Mana)
    {
        this.ManaPoints = Mana;
    }
    public void Set_StaminaPoints(int Stamina)
    {
        this.StaminaPoints = Stamina;
    }
    public void Set_HolyEnergyPoints(int Faith)
    {
        this.HolyEnergyPoints = Faith;
    }
    

    //Lose 
    public void Lose_Health(int HealthCost)
    {
        if (this.HealthPoints >= HealthCost)
        {
            this.HealthPoints -= HealthCost;
        }
        else
        {
            this.HealthPoints = 0;
        }
    }
    public void Lose_Mana(int ManaCost)
    {
        if (this.ManaPoints >= ManaCost)
        {
            this.ManaPoints -= ManaCost;
        }
        else
        {
            this.ManaPoints = 0;
        }
    }
    public void Lose_Stamina(int StaminaCost)
    {
        if (this.StaminaPoints >= StaminaCost)
        {
            this.StaminaPoints -= StaminaCost;
        }
        else 
        {
            this.StaminaPoints = 0;
        }
    }
    public void Lose_HolyEnergyPoints(int HolyEnergyCost)
    {
        if (this.HolyEnergyPoints >= HolyEnergyCost)
        {
            this.HolyEnergyPoints -= HolyEnergyCost;
        }
        else
        {
            this.HolyEnergyPoints = 0;
        }
    }








}
