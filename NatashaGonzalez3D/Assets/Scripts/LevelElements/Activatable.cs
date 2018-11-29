using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatable : MonoBehaviour {

    protected bool activable;
    protected List<Activator> LinkedActivators = new List<Activator>();

    public void LinkActivator(Activator activator) {
        LinkedActivators.Add(activator);
    }
    public void [] LinkedActivators{
        return LinkedActivators.ToArray();
    }
    public virtual void OnStart() {

    }

    public virtual void OnActive() {

    }

    public virtual void OnEnd() {

    }
}