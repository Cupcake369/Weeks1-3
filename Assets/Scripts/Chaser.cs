using UnityEngine;
using UnityEngine.InputSystem;

public class Chaser : MonoBehaviour
{
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = Mouse.current.position.ReadValue();// Get the current mouse position in screen coordinates
        Vector3 worldMousePosition = gameCamera.ScreenToWorldPoint(currentMousePosition); // Convert the screen coordinates to world coordinates
        worldMousePosition.z = 0; // Set z to 0 to keep the object on the same plane
        transform.position = worldMousePosition;
    }
}
