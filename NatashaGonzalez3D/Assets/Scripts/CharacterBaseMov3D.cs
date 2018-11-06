using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterBaseMov3D : MonoBehaviour
{

    Rigidbody rigBod;
    Vector3 movement;
    Vector3 RespawnPos;

    public float speed = 5f;
    public float jumpForce = 10f;

    // Use this for initialization
    void Start()
    {
        rigBod = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rigBod.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
    }


    void FixedUpdate()
    {
        movement.z = Input.GetAxis("Vertical");
        rigBod.MovePosition(rigBod.position + (movement * speed * Time.fixedDeltaTime));
    }

    void Respawn(){
        rigBod.velocity = Vector3.zero;
    }

    void OnTriggerExit(Collider other){
        if (other.CompareTag("GameArea")){
            Respawn();
        }
    }
}