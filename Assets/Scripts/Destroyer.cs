using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroyer : MonoBehaviour {
    void OnCollisionEnter2D(Collision2D collision) {
        GameObject collider = collision.collider.gameObject;
        GameObject.Destroy(collider);
    }

    void OnTriggerEnter2D(Collider2D collider) {
        GameObject.Destroy(collider.gameObject);
    }
}
