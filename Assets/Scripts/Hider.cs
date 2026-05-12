using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;
public class Hider : MonoBehaviour
{
    public float distanceFromMouse;
    public Vector3 hidePosition;
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    
    }

    // Update is called once per frame
    void Update()
    {
        
        // Convert the mouse position from screen coordinates to world coordinates
        // Get the current position of the mouse in screen coordinates
        Vector3 mousePosition = gameCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        mousePosition.z = 0; // Set z to 0 to keep the mouse position on the same plane as the object



        // ENTER THIS SECTION
        // If the mouse is close to this object
        float distance = Vector3.Distance(mousePosition, transform.position); // Calculate the distance between the mouse and this object

        //Debug.Log(distance);
        if (distance < distanceFromMouse) 
        {
            hidePosition.x +=0.05f; // Move the hide position to the right


            //Lil Trick for just moving the x value
            // We made a vector to take the current position
            Vector3 newPosition = transform.position;
            //We just take the x value
            newPosition.x = hidePosition.x;
            //we Spit out just the x value to transform.position;
            transform.position = newPosition;
        }
        
    }
}
