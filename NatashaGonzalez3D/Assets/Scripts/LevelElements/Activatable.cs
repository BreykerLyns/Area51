using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Activatable : MonoBehaviour
{

<<<<<<< HEAD
    protected bool activated;
    protected List<Activator> linkedActivators = new List<Activator>();

    public void LinkActivator (Activator activator) {
        linkedActivators.Add(activator);
    }

    public Activator[] LinkedActivators (){
        return linkedActivators.ToArray();
    }

	public virtual void OnStart () {
        
    }

    public virtual void OnActive () {
        
    }

    public virtual void OnEnd () {
        
=======
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

>>>>>>> 37f239c62afbb390e04c4d32f13bf83178a55653
    }
}