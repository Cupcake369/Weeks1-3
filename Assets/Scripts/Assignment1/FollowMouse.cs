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
        //take mousepos and convert it into ingame position
        Vector2 currentMousePosition = gameCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        //take the pos that was converted and put that value as postion of the gameobject
        transform.position = currentMousePosition;
    }
}
