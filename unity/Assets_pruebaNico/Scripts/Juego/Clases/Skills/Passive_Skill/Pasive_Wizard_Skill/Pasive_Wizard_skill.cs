using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pasive_Wizard_skill : Passive_Skill
{

    [SerializeField]bool Is_Active=false;
    [SerializeField] string[] BonusEfectArea;
    [SerializeField] int[] BonusEfect;




    //Setters
    public void Set_Is_Active(bool Is_Active)
    {
        this.Is_Active = Is_Active;
    }
    public void Set_BonusEfetArea(string[] BonusEfectArea)
    {
        this.BonusEfectArea = BonusEfectArea;
    }
    public void Set_BonusEfect(int[] BonusEfect)
    {
        this.BonusEfect = BonusEfect;
    }

    //Getters
    public bool Get_Is_Active()
    {
        return this.Is_Active;
    }
    public string[] Get_BonusEfectArea()
    {
        return this.BonusEfectArea;
    }
    public int[] Get_BonusEfect()
    {
        return this.BonusEfect;
    }




}
