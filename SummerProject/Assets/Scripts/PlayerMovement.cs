using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
// speed variable
    public float moveSpeed = 5f;
// reference variable
    public Rigidbody2D rb;
// container variable
    Vector2 movement;

    void Update() {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }
// Takes position of Player, normalizes the direction of movement, multiplies the direction by movement speed, then multiplies by Time
    void FixedUpdate() {
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
    }
}
