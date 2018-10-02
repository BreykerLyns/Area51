using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utilities2D;

public class MovimientoContinuo2D : MonoBehaviour {

	public float speed;
	public List<AxisPair> axes;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 movement = Vector3.zero;
		for (int i = 0; i < axes.Count; i++) {
            if (Input.GetKey(axes[i].keyCode) && !FindObstacle(axes[i].direction/2)) {
				movement += axes[i].direction;
			}
		}
		movement = movement.normalized * speed * Time.deltaTime;
		transform.Translate(movement);
	}

    internal void OnTriggerEnter2D (Collider2D other) {
        if (other.CompareTag("Barrel")){
            Debug.Log ("Chocaste!");
        } else if (other.CompareTag("CamArea")) {
            Camera.main.GetComponent <CamControl
        }
    }

    bool FindObstacle (Vector3 direction) {
        RaycastHit2D hit2D = Physics2D.Raycast (transform.position, direction, 0.5f);
        Debug.DrawRay(transform.position, direction / 2, Color.green);

        return hit2D && hit2D.collider.CompareTag ("StaticBlock");
    }
}
