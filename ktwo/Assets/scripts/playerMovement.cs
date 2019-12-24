using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    private CharacterController playerController;
    public float playerSpeed;
    private Vector3 movePlayer;
    private float verticalVelocity = 0.0f;
    private float gravity = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        playerController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        movePlayer = Vector3.zero;
        if(playerController.isGrounded){
            verticalVelocity = 0.02f;

        }else{
            verticalVelocity -= gravity * Time.deltaTime;

        }
        movePlayer.x = Input.GetAxis("Horizontal") * playerSpeed;
        movePlayer.y = verticalVelocity;
        movePlayer.z = playerSpeed;
        playerController.Move (movePlayer * Time.deltaTime);
        
    }
}
