using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatable : MonoBehaviour
{

    protected bool activated;
    protected List<Activator> linkedActivators = new List<Activator>();

    public void LinkActivator (Activator activator) {
        linkedActivators.Add(activator);
    }

    public Activator[] LinkedActivators (){
        return linkedActivators.ToArray();
    }

	protected virtual void Start () {
        if (linkedActivators.Count == 0) {
            OnStart();
        }
	}

	public virtual void OnStart () {
        
    }

    public virtual void OnActive () {
        
    }

    public virtual void OnEnd () {
        
    }
}
