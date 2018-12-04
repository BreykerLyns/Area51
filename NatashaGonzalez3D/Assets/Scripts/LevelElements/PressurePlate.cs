using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : Activator {

<<<<<<< HEAD
	protected override void ActivateStart (Activatable activatable){
        activatable.OnStart();
	}

    protected override void ActivateEnd (Activatable activatable, bool recall = true) {
        base.ActivateEnd(activatable, recall);
	}

	void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            ActivateStart(target);
        }
	}
    void OnTriggerExit(Collider other) {
        if (other.CompareTag("Player")) {
            ActivateEnd(target);
        }
    }
}
=======
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
>>>>>>> 37f239c62afbb390e04c4d32f13bf83178a55653
