using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {

    public override bool Use() {
        return false;
    }

    public virtual void ActivateStart (Activatable activatable) {
        Debug.Log("Process Started Sent");
    }

    public virtual void ActivateEnd(Activatable activatable) {
        Debug.Log("Process Started Sent");
    }
}