using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private CharacterController player;
    private float horizontalMove;
    private float verticalMove;
    private Vector3 playerInput;
    public float playerSpeed=10.0f;
    private Vector3 movePlayer;
    public float gravity=9.8f;
    private float fallVelocity;
    public float jumpForce=8.0f;

    public Camera mainCamera;
    private Vector3 camForward; //direccion hacia adelante
    private Vector3 camRight; //direccion hacia la derecha

    //para golpear un cubo
    private bool isOnSlope=false;
    private Vector3 hitNormal;
    public float slideVelocity=3.0f;
    public float slopeForceDown=-10.0f; 
    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontalMove=Input.GetAxis("Horizontal");
        verticalMove=Input.GetAxis("Vertical");
        playerInput=new Vector3(horizontalMove,0,verticalMove);
        playerInput= Vector3.ClampMagnitude(playerInput,1);
        camDirection();
        movePlayer=playerInput.x * camRight + playerInput.z * camForward;
        movePlayer=movePlayer * playerSpeed;
        player.transform.LookAt(player.transform.position + movePlayer);

        SetGravity();
        //habilidades del jugador ejemplo detecta el salto
        PlayerSkills();
        //se mueve en base a la camara
        player.Move(movePlayer *  Time.deltaTime);
        //este se mueve sin que la camara lo siga
        //player.Move(playerInput * playerSpeed * Time.deltaTime);
    }
    void camDirection(){
        camForward=mainCamera.transform.forward;
        camRight=mainCamera.transform.right;
        camForward.y=0;
        camRight.y=0;
        //es para tener una direccion mas ajustada de hacia donde mira el vector
        camForward=camForward.normalized;
        camRight=camRight.normalized;

    }
    void SetGravity(){
        if (player.isGrounded){
            fallVelocity=-gravity *  Time.deltaTime;
            movePlayer.y=fallVelocity;
        }
        else{
            fallVelocity -=gravity *  Time.deltaTime;
            movePlayer.y=fallVelocity;
        }
        SlideDown();
    }
    void PlayerSkills(){
        if (player.isGrounded && Input.GetButtonDown("Jump")){
            fallVelocity=jumpForce;
            movePlayer.y=fallVelocity;
        }
    }
    public void OnControllerColliderHit(ControllerColliderHit hit){
            //detecta cuando character controler colisiona con otro objeto
            hitNormal=hit.normal;
    }
    public void SlideDown(){
        //compara si está en una rampa
        //angulo entre el vecotr hacia arriba y la normal que detectamos en la colision >= angulo maximo del character controller
        isOnSlope =Vector3.Angle(Vector3.up,hitNormal)>= player.slopeLimit;
        if (isOnSlope){
            //estamos en una rampa muy inclinada
            movePlayer.x += ((1f - hitNormal.y) * hitNormal.x) +   slideVelocity;
            movePlayer.z += ((1f - hitNormal.y) * hitNormal.z) +   slideVelocity;
            movePlayer.y += slopeForceDown;
        }
    }

}
