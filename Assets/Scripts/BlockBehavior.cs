using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockBehavior : MonoBehaviour {
    public Rigidbody2D rigidBody;
    public BoxCollider2D collider;

    // Start is called before the first frame update
    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
        collider = GetComponent<BoxCollider2D>();
    }

    void OnCollisionEnter2D(Collision2D collision) {
        rigidBody.constraints = new RigidbodyConstraints2D();
        collider.isTrigger = true;
    }
}
