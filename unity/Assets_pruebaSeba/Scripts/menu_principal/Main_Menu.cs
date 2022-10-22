using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class btn_Jugar : MonoBehaviour
{
    public string EscenaNivel1 = "Nivel1";
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void jugar()
    {
        Time.timeScale = 1.0F;

        SceneManager.LoadScene(EscenaNivel1);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
