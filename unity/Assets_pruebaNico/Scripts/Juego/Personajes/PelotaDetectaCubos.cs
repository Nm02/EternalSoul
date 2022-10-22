using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PelotaDetectaCubos : MonoBehaviour
{

    public float velocidad;
    public Text textoCantidad;
    public Text textoGanaste;
    public float salto=200f;
    public int final;

    private Rigidbody rb;
    private int count;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        count = 0;
        SettextoCantidad();
        
        if (textoGanaste != null)
        {
            textoGanaste.text = "";
        }

    }

    void FixedUpdate()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Vector3 movement = new Vector3(0, salto, 0);
            rb.AddForce(movement);


        }
        else
        {
            Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), 0.0f, Input.GetAxis("Vertical"));
            //agrega al movimiento la velocidad
            rb.AddForce(movement * velocidad);
        }
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("juntar"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SettextoCantidad();
        }
    }

    void SettextoCantidad()
    {
        if (textoCantidad != null)
        {
            textoCantidad.text = "Puntos: " + count.ToString();
        }
        
        if (count >=final)
        {
            if (textoGanaste != null)
            {
                textoGanaste.text = "Ganaste!";
            }            
        }
    }
}