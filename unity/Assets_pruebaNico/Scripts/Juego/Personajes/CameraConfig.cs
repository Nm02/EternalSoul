using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraConfig : MonoBehaviour
{
    public GameObject Target;
    Vector3 offset;
    private GameObject Player;
    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        offset = transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Camera.main.transform.LookAt(Player.transform.position);
        transform.position = Target.transform.position + offset;
    }
}
