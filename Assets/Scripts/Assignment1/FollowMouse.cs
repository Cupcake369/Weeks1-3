using UnityEngine;
using UnityEngine.InputSystem;

public class FollowMouse : MonoBehaviour
{
    public Camera gameCamera;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 currentMousePosition = gameCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        transform.position = currentMousePosition;
    }
}
