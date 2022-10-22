using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using Skills;

public class Player : Entity
{
    [SerializeField] SkillsInventory PlayerSkillInventory;
    
    [SerializeField] int PlayerLevel;
    [SerializeField] int IntelligenceLevel=0;
    [SerializeField] int FaithLevel=0;
    [SerializeField] int StrengthLevel=0;

    [SerializeField] int[] IntelligenceByLevel=new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21};
    [SerializeField] int[] FaithByLevel = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };
    [SerializeField] int[] StrengthByLevel = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19, 21 };

    [SerializeField] int IntelligencePoints;
    [SerializeField] int FaithPoints;
    [SerializeField] int StrengthPoints;

    [SerializeField] int CurrentSkillPoints=0;
    [SerializeField] int TotalSkillPoints=0;

    [SerializeField] Skill BasicAttack;

    [SerializeField] Skill MainAttack;
    [SerializeField] Skill SecondaryAttack;
    
    Animator anim;

    
    
    // Start is called before the first frame update
    void Start()
    {
        //this.anim = GetComponent<Animator>();
    }

    
    // Update is called once per frame
    void Update()
    {
        
    }


    /*

    //player lever up and Stats
    public void Player_LevelUp()
    {
        this.PlayerLevel += 1;
        this.CurrentSkillPoints += 1;
        this.TotalSkillPoints += 1;
    }
    public void Intelligence_LevelUp()
    {
        if (this.CurrentSkillPoints > 0)
        {
            this.IntelligenceLevel += 1;
            Update_IntelligencePoints();
            Update_ManaPoints();
        }
        
    }
    public void Faith_LevelUp()
    {
        if (this.CurrentSkillPoints > 0)
        {
            this.FaithLevel += 1;
            Update_FaithPoints();
            Update_HolyEnergyPoints();
        }
    }
    public void Strength_LevelUp()
    {
        if (this.CurrentSkillPoints > 0)
        {
            this.StrengthLevel += 1;
            Update_StrengthPoints();
            Update_StaminaPoints();
        }
    }


    //Update Stats
    void Update_IntelligencePoints()
    {
        this.IntelligencePoints = this.IntelligenceByLevel[this.IntelligenceLevel];
    }
    void Update_FaithPoints()
    {
        this.FaithPoints = this.FaithByLevel[this.FaithLevel];
    }
    void Update_StrengthPoints()
    {
        this.StrengthPoints = this.StrengthByLevel[this.StrengthLevel];
    }
    void Update_ManaPoints()
    {
        Update_IntelligencePoints();
        int ManaPoints = this.IntelligencePoints;
        Set_ManaPoints(ManaPoints);
    }
    void Update_StaminaPoints()
    {
        Update_StrengthPoints();
        int StaminaPoints = this.StrengthPoints;
        Set_StaminaPoints(StaminaPoints);
    }
    void Update_HolyEnergyPoints()
    {
        Update_FaithPoints();
        int HolyEnergyPoints = this.FaithPoints;
        Set_StaminaPoints(HolyEnergyPoints);
    }




    //Reset Stats
    public void Reset_Stats()
    {
        this.IntelligenceLevel = 0;
        this.FaithLevel = 0;
        this.StrengthLevel = 0;
        Update_IntelligencePoints();
        Update_FaithPoints();
        Update_StrengthPoints();
        this.CurrentSkillPoints = this.TotalSkillPoints;
    }


    //Set Skills and Attacks
    public void Set_MainAttack(Skill NewAttack)
    {
        this.MainAttack = NewAttack;
    }
    public void Set_SecondaryAttack(Skill NewAttack)
    {
        this.SecondaryAttack = NewAttack;
    }
    */
}
