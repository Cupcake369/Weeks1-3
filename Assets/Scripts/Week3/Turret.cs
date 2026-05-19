using UnityEngine;
using UnityEngine.InputSystem;

public class Turret : MonoBehaviour
{
    public Transform target; // The target the turret will aim at
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bool isLeftKeyPressed = Keyboard.current.leftArrowKey.isPressed;

        bool leftmouseIsPressed = Mouse.current.leftButton.isPressed; // Check if the left mouse button is pressed
        bool leftmouseWasPressed = Mouse.current.leftButton.wasPressedThisFrame; // Check if the left mouse button was pressed this frame
        bool leftmouseWasReleased = Mouse.current.leftButton.wasReleasedThisFrame; // Check if the left mouse button was released this frame
        Debug.Log(leftmouseIsPressed);





        if (leftmouseIsPressed) {


            // Direction to B from A: B-A
            // The direction from this object towards the target
            Vector3 directionToTarget = target.position - transform.position;
            transform.up = directionToTarget; // Set the up vector of the turret to point towards the target
        }
        
    }
}
