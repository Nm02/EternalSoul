using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Menu_Estadisticas : MonoBehaviour
{
    public Text TNombre;
    public Text TClase;
    public Text TNivel;

    public Text TVitalidad;
    public Text TFuerza;
    public Text TAgilidad;
    public Text TInteligencia;
    public Text TResistencia;

    public Text TVida;
    public Text TDaño;
    public Text TDefensa;
    public Text TMana;
    public Text TEnergia;

    public Text TPuntosH;

    public Estadisticas_Caracteristicas Estadisticas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TNombre.text = "Nombre: " + Estadisticas.Nombre;
        TClase.text = "Clase: " + Estadisticas.Clase;
        TNivel.text = "Nivel: " + Estadisticas.Nivel;

        TVitalidad.text = "Vitalidad: " + Estadisticas.Vitalidad;
        TFuerza.text = "Fuerza: " + Estadisticas.Fuerza;
        TAgilidad.text = "Agilidad: " + Estadisticas.Agilidad;
        TInteligencia.text = "Inteligencia: " + Estadisticas.Inteligencia;
        TResistencia.text = "Resistencia: " + Estadisticas.Resistencia;

        TVida.text = "Vida: " + Estadisticas.Vida;
        TDaño.text = "Daño: " + Estadisticas.Daño;
        TDefensa.text = "Defensa: " + Estadisticas.Defensa;
        TMana.text = "Mana: " + Estadisticas.Mana;
        TEnergia.text = "Energia: " + Estadisticas.Energia;

        TPuntosH.text = "Puntos: " + Estadisticas.PuntosH;
    }

    public void btn_MasVitalidad()
    {
        if (Estadisticas.PuntosH > 0)
        {
            Estadisticas.Vitalidad += 1;
            Estadisticas.PuntosH -= 1;
        }
    }

    public void btn_MasFuerza()
    {
        if (Estadisticas.PuntosH > 0)
        {
            Estadisticas.Fuerza += 1;
            Estadisticas.PuntosH -= 1;
        }
    }

    public void btn_MasAgilidad()
    {
        if (Estadisticas.PuntosH > 0)
        {
            Estadisticas.Agilidad += 1;
            Estadisticas.PuntosH -= 1;
        }
    }

    public void btn_MasInteligencia()
    {
        if (Estadisticas.PuntosH > 0)
        {
            Estadisticas.Inteligencia += 1;
            Estadisticas.PuntosH -= 1;
        }
    }

    public void btn_MasResistencia()
    {
        if (Estadisticas.PuntosH > 0)
        {
            Estadisticas.Resistencia += 1;
            Estadisticas.PuntosH -= 1;
        }    
    }
}
