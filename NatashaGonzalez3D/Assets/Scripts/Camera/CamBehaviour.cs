using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EntityData.StructLib;

public class CamBehaviour : MonoBehaviour {

    private TargetData defaultData;
    public TargetData data;
    
    Vector3 focusPoint { get { return data.target.position + GetRelativePos(data.target, data.focusDistance); } }
    Vector3 followPoint { get { return data.target.position + GetRelativePos(data.target, data.followDistance); } }
    public float followDistanceDelta { get { return Vector3.Distance(transform.position, followPoint); } }

    static public CamBehaviour main;

	void Awake () {
        main = Camera.main.GetComponent<CamBehaviour>();
	}

	// Use this for initialization
	void Start () {
        //defaultData.SetFromVariables(target, focusDistance, followDistance, minFollowSpeed);
        defaultData = data;
	}
	
	// Update is called once per frame
	void LateUpdate () {
        transform.LookAt(focusPoint);
        transform.position = Vector3.MoveTowards(transform.position, followPoint, (data.minFollowSpeed + followDistanceDelta) * Time.deltaTime);
	}

    Vector3 GetRelativePos (Transform relativeTarget, Vector3 distace) {
        Vector3 relativePos;
        relativePos = relativeTarget.right * distace.x;
        relativePos += relativeTarget.up * distace.y;
        relativePos += relativeTarget.forward * distace.z;

        return relativePos;
    }

    public void Reposition (Vector3 updatedPosition) {
        transform.position = updatedPosition;
    }
    public void ResetData () {
        data = defaultData;
    }

	void OnDrawGizmos () {
        if (data.target) {
            Gizmos.color = Color.green;
            Gizmos.DrawLine(followPoint, focusPoint);
            Gizmos.DrawWireSphere(followPoint, 0.25f);
            Gizmos.color = Color.white;
            Gizmos.DrawSphere(focusPoint, 0.15f);
        }
	}
}
