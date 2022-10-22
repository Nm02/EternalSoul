using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Estadisticas_Caracteristicas : MonoBehaviour
{
    public string Nombre="SinNombre";
    public string Clase="Nada";
    public int Nivel=1;

    public int Vitalidad=1;
    public int Fuerza=1;
    public int Agilidad=1;
    public int Inteligencia=1;
    public int Resistencia=1;

    [HideInInspector] public int Vida;
    [HideInInspector] public int Daño;
    [HideInInspector] public int Defensa;
    [HideInInspector] public int Mana;
    [HideInInspector] public int Energia;

    public MobaPlayer Jugador;

    public int PuntosH = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vida = Vitalidad * 10;
        Daño = Fuerza;
        Defensa = (Resistencia * 5) + (Agilidad * 5);
        Mana = Inteligencia * 10;
        Energia = (Resistencia * 5);
        Jugador.MaxStamina = Energia;
    }
}
