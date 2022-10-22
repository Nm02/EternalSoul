using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HigligthItems : MonoBehaviour
{
    Material material;
    Color original;
    // Start is called before the first frame update
    void Start()
    {
        material = GetComponent<Renderer>().material;
        original = material.color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnMouseEnter()

    {
        material.color = Color.black;
    
    }
    private void OnMouseExit()
    {
        material.color = original;
    }
}
