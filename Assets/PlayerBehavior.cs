using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehavior : MonoBehaviour {
    public float Speed = 10.0f;
    public float HorizontalAxis;
    public Rigidbody2D rigidBody;

    // Start is called before the first frame update
    void Start() {
        rigidBody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() {
        HorizontalAxis = Input.GetAxis("Horizontal");
        rigidBody.velocity = new Vector2(Speed * HorizontalAxis, 0.0f);
    }
}
