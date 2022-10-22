using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBall : MagicSkill
{
    [SerializeField] GameObject ProyectilPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Use_Skill(GameObject Player)
    {
        GameObject Proyectil = Instantiate(ProyectilPrefab, Player.transform.position, Quaternion.identity);
        Proyectil.GetComponent<Proyectil>().Usar();

    }
}
