using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EntityPhysicsMov2D : MonoBehaviour {

    public float speed = 1f;
    public Vector2 direction;
    public Vector3 movement { get { return direction * speed * Time.fixedDeltaTime; } }

    public Rigidbody2D rb2D;

    protected virtual void Reset () {
        rb2D = GetComponent<Rigidbody2D> ();
        rb2D.gravityScale = 0;
        rb2D.constraints = RigidbodyConstraints2D.FreezeRotation;
    }

    protected virtual void FixedUpdate () {
        //transform.Translate (movement);
        rb2D.MovePosition (transform.position + movement);
    }
}
