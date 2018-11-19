﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntityData.StructLib;

public class CharacterBaseMov3D : MonoBehaviour {

    Rigidbody rigBod;
    Vector3 movement;

    CharTransformData respawnData;

    public float speed = 5f;
    public float angSpeed = 25f;
    public float jumpForce = 10f;

	// Use this for initialization
	void Start () {
        rigBod = GetComponent<Rigidbody>();
        respawnData.position = transform.position;
        respawnData.rotation = transform.rotation;
	}

	void Update () {
        if (Input.GetKeyDown(KeyCode.Space)) {
            rigBod.AddForce(Vector3.up * jumpForce, ForceMode.VelocityChange);
        }
	}

	void FixedUpdate () {
        movement = transform.forward * Input.GetAxis("Vertical");
        rigBod.MovePosition(rigBod.position + (movement * speed * Time.fixedDeltaTime));
        Quaternion rotation = Quaternion.Euler(Vector3.up * Input.GetAxis("Horizontal") * angSpeed * Time.fixedDeltaTime);
        rigBod.MoveRotation(rotation * rigBod.rotation);
	}

    void Respawn () {
        rigBod.velocity = Vector3.zero;
        Reposition(respawnData);
        CamBehaviour.main.Reposition(respawnData.position + CamBehaviour.main.data.followDistance);
    }
    public void Reposition (CharTransformData transformData) {
        rigBod.MovePosition(transformData.position);
        rigBod.MoveRotation(transformData.rotation);
    }
    public void SetRespawn (CharTransformData transformData) {
        respawnData = transformData;
    }

	void OnTriggerExit (Collider other) {
        if (other.CompareTag("GameArea")) {
            Respawn();
        }
	}
	void OnDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.forward);
	}
}
