using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class detectar_jugador : MonoBehaviour
{
    public bool detecta = false;
    public GameObject perdiste;
    public GameObject menu;
    public float RangoDeAlerta = 20;
    public LayerMask CapaDelJugador;


    // Start is called before the first frame update
    void Start()
    {
        perdiste.SetActive(false);
        menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        detecta= Physics.CheckSphere(transform.position, RangoDeAlerta, CapaDelJugador);
        if (detecta)
        {
            perdiste.SetActive(true);
            menu.SetActive(true);
            Time.timeScale = 0f;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(transform.position, RangoDeAlerta);
    }


}
