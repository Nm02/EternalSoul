using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCharacter : MonoBehaviour
{
    private CharacterController Player;

    private Vector3 Movement = Vector3.zero;

    public int WalkSpeed = 10;
    private int RunSpeed;
    private int Speed;

    public float Gravity = 3;

    public float jumpforce = 10;

    private void Start()
    {
        Player = GetComponent<CharacterController>();
        RunSpeed = WalkSpeed * 2;
        jumpforce *= 10;
        Speed = WalkSpeed;
    }

    private void Update()
    {
        PlayerMovement();

        float mouseX = Input.GetAxis("MouseX");
        float mouseY = Input.GetAxis("MouseY");

    }
    void PlayerMovement()
    {
        if (Player.isGrounded)
        {
            Movement = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            if (Input.GetKey(KeyCode.LeftShift))
            {
                Speed = RunSpeed;
            }
            else
            {
                Speed = WalkSpeed;
            }
            if (Input.GetKey(KeyCode.Space))
            {
                Movement.y = jumpforce;
            }
        }

        Movement.y -= Gravity;
        Player.Move(Movement * Time.deltaTime * Speed);

    }
}
