using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Activator {

    public bool isSwitched;
    public Color activeColor;
    public Color inactiveColor;

	void Start () {
        GetComponent<Renderer>().material.color = inactiveColor;
	}

    public override bool Use () {
        if (!isSwitched) { ActivateStart(target); } else { ActivateEnd(target); }
        return isSwitched;
    }

<<<<<<< HEAD
    protected override void ActivateStart (Activatable activatable) {
        isSwitched = true;
        GetComponent<Renderer>().material.color = activeColor;
        Debug.Log(activatable.name + " Start");
=======
	protected override void ActivateStart (Activatable activatable) {
        isSwitched = true;
        GetComponent<Renderer>().material.color = activeColor;
        Debug.Log(activatable.name + "Start");
>>>>>>> 37f239c62afbb390e04c4d32f13bf83178a55653
        activatable.OnStart();
	}

    protected override void ActivateEnd (Activatable activatable, bool recall = true) {
        isSwitched = false;
        GetComponent<Renderer>().material.color = inactiveColor;
<<<<<<< HEAD
        Debug.Log(activatable.name + " End");
        base.ActivateEnd(activatable, recall);
=======
        Debug.Log(activatable.name + "End");
        base.ActivateEnd(activatable, true);
>>>>>>> 37f239c62afbb390e04c4d32f13bf83178a55653
    }
}
