using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallInitialBehavior : MonoBehaviour {
    public Vector2 Speed;

    // Start is called before the first frame update
    void Start() {
        Rigidbody2D rigidBody = GetComponent<Rigidbody2D>();
        rigidBody.AddForce(Speed); // rigidBody.addForce(new Vector2(10.0f, 10.0f));
    }
}
