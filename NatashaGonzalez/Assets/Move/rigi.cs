using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rigi : MonoBehaviour {
    public float velocidad = 10;
    Rigidbody miRigdBody;

    // Use this for initialization
    void Start () {
        miRigdBody = GetComponent<Rigidbody>();

        }
	
	// Update is called once per frame
	void Update () {
        float vertical = Input.GetAxis("Vertical");
        float horizontal = Input.GetAxis("Horizontal");
        miRigdBody.MovePosition(miRigdBody.position + new Vector3(horizontal, 0, vertical) * velocidad * Time.deltaTime);
        miRigdBody.velocity = Vector3.zero;

        }
}
