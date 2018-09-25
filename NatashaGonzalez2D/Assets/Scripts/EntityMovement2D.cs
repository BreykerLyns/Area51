using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityMovement2D : MonoBehaviour {

    public float speed = 1f;
    public Vector2 direction;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(direction * speed * Time.deltaTime);
		
	}
}
