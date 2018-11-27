using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : Activator {

    public bool isSwitched;
    public Color activeColor;
    public Color inactiveColor;

	void Start() {
        GetComponent<Renderer>().material.color = inactiveColor;
    
	}

	public override void ActivateStart(Activatable activatable) {
        isSwitched = true;
        GetComponent<Renderer>().material.color = activeColor;
	}
}
