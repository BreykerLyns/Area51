using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : Activator {

    protected override void ActivateStart(Activatable activatable) {
        activatable.OnStart();
   }
    protected override void ActivateEnd(Activatable activatable, bool recall = true) {
        activatable.OnEnd();
    }

   void OnTriggerEnter(Collider other) {
        if (other.CompareTag("PLayer")) {

            ActivateStart(target);
        }
    }

    void OnTriggerExit(Collider other) {
        if (other.CompareTag("PLayer")) {

            ActivateEnd(target);
        }
    }
}