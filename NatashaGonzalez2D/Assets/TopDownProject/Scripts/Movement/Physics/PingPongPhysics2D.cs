using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PingPongPhysics2D : MonoBehaviour {
    
    public float distance = 1;
    private float currentDistance;
	
	// Update is called once per frame
	void Update () {
        protected override void Update() {
        currentDistance += movement.magnitude;

        //Logica PingPong
        if (currentDistance >= distance)
        {
            float delta = totalMovement - distance;
            transform.Translate(direction.normalized * delta);
            direction *= -1;
            currentDistance = 0;
        } else {
            base.Update();
	}
}
