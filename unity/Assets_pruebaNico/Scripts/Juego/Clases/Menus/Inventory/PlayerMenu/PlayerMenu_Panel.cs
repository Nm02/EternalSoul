using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMenu_Panel : MonoBehaviour
{
    


    //Particular Voids
    public void Open()
    {
        gameObject.SetActive(true);
    }
    public void Close()
    {
        gameObject.SetActive(false);
    }

}
