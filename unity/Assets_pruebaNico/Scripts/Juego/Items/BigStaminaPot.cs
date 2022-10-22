using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigStaminaPot : MonoBehaviour
{
    [HideInInspector]
    public MobaPlayer Player;
    private GameObject ReferenceObject;
    bool take;
    // Start is called before the first frame update
    void Start()
    {
        ReferenceObject = GameObject.FindGameObjectWithTag("Player");
        Player = ReferenceObject.GetComponent<MobaPlayer>();
        Rigidbody Rigidbody = gameObject.AddComponent(typeof(Rigidbody)) as Rigidbody;
        take = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            
            Player.Stamina = Player.MaxStamina;
            if (take==true)
            {
                gameObject.SetActive(false);
            }
            

        }
    }
    private void OnMouseOver()
    {
        if (Input.GetButton("Fire1"))
        {
            take = true;
        }
    }
}