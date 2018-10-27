using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterStateEvent : MonoBehaviour {

	public Color currentColor;
	public Gradient colorSet;
	[Range(0,1)]
	public float targetTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		currentColor = colorSet.Evaluate(targetTime);
	}
}
