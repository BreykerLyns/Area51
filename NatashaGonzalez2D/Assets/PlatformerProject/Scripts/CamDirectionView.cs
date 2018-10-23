using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamDirectionView : MonoBehaviour {

    public Transform targetEntity;
    MouseTargetBehaviour mouseScript;
    public float moveSpeed = 1f;

	// Use this for initialization
	void Start () {
        mouseScript = targetEntity.GetComponent<MouseTargetBehaviour>();
	}

    // Update is called once per frame
    void LateUpdate() {
        //vector3 targetPos = new Vector3
        Vector3 point = targetEntity.position + (mouseScript.direction * 5f);
        Vector3 targetPos = new Vector3(point.x, point.y, transform.position.z);
        MoveToTarget(targetPos);
    }
		
        void MovetoTarget (Vector3 target) {
            
        }
	}
}
