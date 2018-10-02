using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour {

    public Transform defaultTarget;
    public float defaultSize = 5;
    public Transform currentTarget;
    public float currentSize;
    public float speed;
    public float zoomSpeed = 
    public Vector3 camPosition { get { return Camera.main.transform.position; }}

    public float[] axisLimits;

	// Use this for initialization
	void Start () {
        currentTarget = defaultTarget;
        currentSize = defaultSize;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.position = Vector3.MoveTowards (transform.position, ConvertToCamDepth(CheckCamLimit(currentTarget.position).position), speed * Time.deltaTime);
        if (Camera.main.orthographicSize != currentSize) {
            Camera.main.orthographicSize = Mathf.MoveTowards (Camera.main.orthographicSize,currentSize,)
        }
    }

    Vector3 CheckCamLimit (Vector3 vector) {
        if (currentTarget.position.y <= axisLimits[3] && camPosition.y <= axisLimits [3]) {
            vector.y = axisLimits[3];
        }
        return vector;
    }

    Vector3 ConvertToCamDepth (Vector3 vector) {
        return new Vector3 (vector.x, vector.y, camPosition.z);
    }

    public void Switcharget (Transform target, float size =5) {
        currentTarget = target == null ? defaultTarget : target;
    }
}
