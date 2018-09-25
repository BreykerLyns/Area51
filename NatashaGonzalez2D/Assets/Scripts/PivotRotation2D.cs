using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PivotRotation2D : EntityMovement2D {

    public Vector2 pivotDirection;
    public float pivotDistance;

    public Vector3 pivotPosition { get { return transform.position + ((Vector3)pivotDirection * pivotDistance); }}

	// Use this for initialization
	void Start () {
		
	}

	protected override void Update() {

        direction = (pivotPosition - transform.position).normalized;
        direction = Vector2.Perpendicular(direction);

        base.Update();
	}

    void onDrawGizmos () {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(pivotPosition, 0.15f);
        Gizmos.DrawRay(transform.position, direction);
    }
}