using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_movimiento : MonoBehaviour
{
    public float RangoDeAlerta=6;
    public LayerMask CapaDelJugador;
    public float velocidad=0;

    bool EstarAlerta;

    public Transform ObjectToFollow;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //detectar cuando entra en el rango
        EstarAlerta= Physics.CheckSphere(transform.position, RangoDeAlerta, CapaDelJugador);

        if (EstarAlerta)
        {
            //buscar objeto con tag player y tomar su transformacion
            ObjectToFollow = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            //rotar la pocicion
            //transform.LookAt(ObjectToFollow);
            transform.LookAt(new Vector3(ObjectToFollow.position.x, transform.position.y, ObjectToFollow.position.z));
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(ObjectToFollow.position.x, transform.position.y
                , ObjectToFollow.position.z), velocidad * Time.deltaTime);
        }

    }

    private void OnDrawGizmos()
    {
        //darle un color al gizmos
        Gizmos.color = Color.yellow;
        //dibujar un gizmos
        Gizmos.DrawWireSphere(transform.position, RangoDeAlerta);

    }






}
