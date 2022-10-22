using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenusDeJuego : MonoBehaviour
{
    public GameObject Panel_estadisticas;
    public GameObject Panel_Pausa;
    // Start is called before the first frame update
    void Start()
    {
        Panel_estadisticas.SetActive(false);
        Panel_Pausa.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Panel_estadisticas != null && Input.GetKeyDown(KeyCode.Q) && !Panel_Pausa.activeSelf)
        {
            Panel_estadisticas.SetActive(!Panel_estadisticas.activeSelf);
        }
        if (Panel_Pausa != null && Input.GetKeyDown(KeyCode.Escape) && !Panel_estadisticas.activeSelf)
        {
            Panel_Pausa.SetActive(!Panel_Pausa.activeSelf);
        }
    }
}
