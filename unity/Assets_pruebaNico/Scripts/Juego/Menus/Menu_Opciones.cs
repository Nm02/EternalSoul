using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu_Opciones : MonoBehaviour
{
    public string Escena;
    public MenusDeJuego Menus;
    public GameObject Panel_Pausa;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void btn_MenuPrincipal()
    {
        Time.timeScale = 1.0F;
        SceneManager.LoadScene(Escena);
    }
    public void btn_Continuar()
    {
        Menus.AbrirCerrar_MOpciones();
    }

}
