using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenusDeJuego : MonoBehaviour
{
    public GameObject Panel_estadisticas;
    public GameObject Panel_Pausa;
    public GameObject Lector;
    [HideInInspector] public bool MenuAbierto=false;
    // Start is called before the first frame update
    void Start()
    {
        Panel_estadisticas.SetActive(false);
        Panel_Pausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel_estadisticas != null && Input.GetKeyDown(KeyCode.Q) )
        {
            AbrirCerrar_MEstadisticas();
        }
        if (Panel_Pausa != null && Input.GetKeyDown(KeyCode.Escape) )
        {
            AbrirCerrar_MOpciones();
        }
    }
    public void AbrirCerrar_MEstadisticas()
    {
        if (!MenuAbierto)
        {
            Panel_estadisticas.SetActive(true);
            Lector.SetActive(!Lector.activeSelf);
            MenuAbierto = true;
        }
        else
        {
            if (Panel_estadisticas.activeSelf)
            {
                Panel_estadisticas.SetActive(false);
                Lector.SetActive(!Lector.activeSelf);
                MenuAbierto = false;
            }
        }
    }
    public void AbrirCerrar_MOpciones()
    {
        if (!MenuAbierto)
        {
            Panel_Pausa.SetActive(true);
            Lector.SetActive(!Lector.activeSelf);
            MenuAbierto = true;
        }
        else
        {
            if (Panel_Pausa.activeSelf)
            {
                Panel_Pausa.SetActive(false);
                Lector.SetActive(!Lector.activeSelf);
                MenuAbierto = false;
            }
        }
    }
}
