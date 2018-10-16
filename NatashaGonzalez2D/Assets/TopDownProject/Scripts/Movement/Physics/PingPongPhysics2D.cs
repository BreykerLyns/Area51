using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongPhysics2D : EntityPhysicsMov2D {

    public float distance = 1;
    private float currentDistance;

    // Update is called once per frame
    protected override void FixedUpdate () {
        currentDistance += movement.magnitude;
        //Logica PingPong
        if (currentDistance >= distance) {
            direction *= -1;
            currentDistance = 0;
        }

        base.FixedUpdate ();
    }
}
