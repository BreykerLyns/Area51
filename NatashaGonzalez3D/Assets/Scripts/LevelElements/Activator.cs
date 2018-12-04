using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activator : MonoBehaviour {
<<<<<<< HEAD

    public Activatable target;
	
    void Awake () {
=======
    
    public Activatable target;

	void Awake() {
>>>>>>> 37f239c62afbb390e04c4d32f13bf83178a55653
        if (target) { target.LinkActivator(this); }
	}

	public virtual bool Use () {
        Debug.Log("Calling Use on Activator");
        return false;
    }

    protected virtual void ActivateStart (Activatable activatable) {
        Debug.Log("Process Started Sent");
    }

<<<<<<< HEAD
    protected virtual void ActivateEnd (Activatable activatable, bool recall = true) {
        Debug.Log("Process Ending Sent");
        activatable.OnEnd();
        if (recall) {
            Activator[] activators = activatable.LinkedActivators();
            foreach (Activator activator in activators) {
                if (activator != this) { activator.ActivateEnd(activatable, false); }
            }
        }
=======
    protected virtual void ActivateEnd(Activatable activatable, bool recall = true)
    {
        Debug.Log("Process Ending Sent");
        activatable.OnEnd();
        if (recall){
            Activators[] activators = activatable.LinkActivator();
            foreach (Activator activator in activators){
                if (activator != this) { activator.ActivateEnd(activatable, false); }
            }
            }
>>>>>>> 37f239c62afbb390e04c4d32f13bf83178a55653
    }
}
