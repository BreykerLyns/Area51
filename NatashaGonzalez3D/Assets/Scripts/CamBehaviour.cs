using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamBehaviour : MonoBehaviour {

    public struct TargetData {

        public Transform target;
        public Vector3 focusDistance;
        public Vector3 followDistance;
        public float minFollowSpeed;

        public void SetFromVariables (Transform target, Vector3 focus, Vector3 follow, float minSpeed) {
            this.target = target;
            focusDistance = focus;
            followDistance = follow;
            minFollowSpeed = minSpeed;
            
        }
    }

    public Transform target;
    public Vector3 focusDistance;
    Vector3 focusPoint{ get { return target.position + GetRelativePos(target, focusDistance); }}
    public Vector3 followDistance;
    Vector3 followPoint { get { return target.position + GetRelativePos(target, followDistance); }}
    public float minFollowSpeed = 1f;
    public float followDistanceDelta { get { return Vector3.Distance(transform.position, followPoint); }}

    public TargetData defaultData;

	// Use this for initialization

	void Start () {

        defaultData.SetFromVariables(target, focusDistance, followDistance, minFollowSpeed);
	}

    // Update is called once per frame
    void LateUpdate() {
        transform.position = Vector3.MoveTowards (transform.position, followPoint, (minFollowSpeed + followDistanceDelta) * Time.deltaTime);
        transform.LookAt(focusPoint);
    }

    Vector3 GetRelativePos (Transform relativeTarget, Vector3 distace){
        Vector3 relativePos;
        relativePos = target.right * distace.x;
        relativePos += relativeTarget.up * distace.y;
        relativePos += relativeTarget.forward * distace.z;

        return relativePos;
    }

    public void Reposition(Vector3 updatedPosition) {
        transform.position = updatedPosition;
    }

	void OnDrawGizmos() {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(followPoint, focusPoint);
        Gizmos.DrawWireSphere(followPoint, 0.25f);
        Gizmos.color = Color.white;
        Gizmos.DrawSphere(focusPoint, 0.15f);
    }
}
