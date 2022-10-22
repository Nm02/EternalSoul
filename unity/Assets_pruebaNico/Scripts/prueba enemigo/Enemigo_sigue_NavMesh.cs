using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo_sigue_NavMesh : MonoBehaviour
{
    Transform jugador;
    UnityEngine.AI.NavMeshAgent enemigo;
    bool Mover;
    bool MuyCerca;

    public float RangoDeAtaque = 5;
    public float RangoDeAlerta = 20;
    public LayerMask CapaDelJugador;

    // Use this for initialization
    void Start()
    {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        Mover = Physics.CheckSphere(transform.position, RangoDeAlerta, CapaDelJugador);
        MuyCerca= Physics.CheckSphere(transform.position, RangoDeAtaque, CapaDelJugador);

        if (Mover && !MuyCerca)
        {
            jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
            transform.LookAt(new Vector3(jugador.position.x, transform.position.y, jugador.position.z));
            enemigo.destination = jugador.position;
        }
        else
        {
            enemigo.destination = this.transform.position;
        }
    }

    private void OnDrawGizmos()
    {
        //darle un color al gizmos
        Gizmos.color = Color.green;
        //dibujar un gizmos
        Gizmos.DrawWireSphere(transform.position, RangoDeAlerta);

        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, RangoDeAtaque);
    }
}
