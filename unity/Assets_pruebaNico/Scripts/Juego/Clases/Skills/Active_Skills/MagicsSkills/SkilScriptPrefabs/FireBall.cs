using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MagicSkill
{
    [SerializeField] GameObject ProyectilPrefab;


    public override void Use_Skill(GameObject Player=null,GameObject Target=null)
    {
        GameObject Proyectil = Instantiate(ProyectilPrefab, Player.transform.position, Quaternion.identity);
        //Proyectil.GetComponent<Proyectil>().Usar();

    }
}
