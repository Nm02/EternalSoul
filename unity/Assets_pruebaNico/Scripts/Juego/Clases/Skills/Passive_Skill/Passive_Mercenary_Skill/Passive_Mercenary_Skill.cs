using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Passive_Mercenary_Skill : Passive_Skill
{
    [SerializeField] bool IsLocked = false;
    [SerializeField] string[] AtributeArea;
    [SerializeField] float[] AtributeBonus;


    //Setters
    public void Set_IsLocked(bool IsLocked)
    {
        this.IsLocked = IsLocked;
    }
    public void Set_BonusEfetArea(string[] AtributeArea)
    {
        this.AtributeArea = AtributeArea;
    }
    public void Set_BonusEfect(float[] AtributeBonus)
    {
        this.AtributeBonus = AtributeBonus;
    }

    //Getters
    public bool Get_IsLocked()
    {
        return this.IsLocked;
    }
    public string[] Get_BonusEfectArea()
    {
        return this.AtributeArea;
    }
    public float[] Get_BonusEfect()
    {
        return this.AtributeBonus;
    }

}
