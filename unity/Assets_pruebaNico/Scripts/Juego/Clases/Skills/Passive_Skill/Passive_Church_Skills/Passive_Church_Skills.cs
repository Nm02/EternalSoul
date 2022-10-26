using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passive_Church_Skills : Passive_Skill
{

    [SerializeField] int AvailableAmount;
    [SerializeField] string[] BonusEfectArea;
    [SerializeField] int[] BonusEfect;




    //Setters
    public void Set_AvailableAmount(int AvailableAmount)
    {
        this.AvailableAmount = AvailableAmount;
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
    public int Get_AvailableAmount()
    {
        return this.AvailableAmount;
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
