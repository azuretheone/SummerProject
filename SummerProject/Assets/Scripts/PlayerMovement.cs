using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
// speed variables
    public float runSpeed = 12f;
    public float moveSpeed = 7f;
    public float crouchSpeed = 4f;
// reference variable
    public Rigidbody2D rb;
// container variable
    Vector2 movement;
// boolean variables
    bool isRunning = false;
    bool isCrouching = false;

    void Update() {
// Stores horizontal movement value
        movement.x = Input.GetAxisRaw("Horizontal");
// Stores vertical movement value
        movement.y = Input.GetAxisRaw("Vertical");
// If LShift is pressed, enable isRunning
        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            isRunning = true;
        }
// If LShift is released, disable isRunning 
        else {
            isRunning = false;
        }
// If Control or C is pressed, enable isCrouching
        if (Input.GetKeyDown(KeyCode.LeftControl)) {
            isCrouching = true;
        } else if (Input.GetKeyDown(KeyCode.C)) {
            isCrouching = true;
        }
// If Control or C is released, disable isCrouching
        else {
            isCrouching = false;
        }
    }
// Takes position of Player, normalizes the direction of movement, multiplies the direction by movement speed, then multiplies by Time
    void FixedUpdate() {
        if (isRunning = true) {
            rb.MovePosition(rb.position + movement.normalized * runSpeed * Time.fixedDeltaTime);
        }
        else if (isCrouching = true) {
            rb.MovePosition(rb.position + movement.normalized * crouchSpeed * Time.fixedDeltaTime);
        }
        else {
            rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime);
        }
    }
}

