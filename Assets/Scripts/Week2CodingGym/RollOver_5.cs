using UnityEngine;
using UnityEngine.InputSystem;

public class RollOver_5 : MonoBehaviour
{
    public float distanceFromMouse; 
    public bool timerIsRunning = false;
    public Camera gameCamera;
    public float timerDuration; // Duration for the timer 
    float timer = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentMousePosition = gameCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        currentMousePosition.z = 0;
        //Debug.Log(currentMousePosition);
        Vector3 currentObjectPos = transform.position;


        float distance = Vector3.Distance(currentMousePosition, currentObjectPos);

        if (distance < distanceFromMouse) 
        {
        timerIsRunning = true;
        }
        if (timerIsRunning == true)
        {
            timer += Time.deltaTime; // Increment the timer by the time elapsed since the last frame
            Debug.Log(timer);
        }

        //timer starts now
        //if timer reaches the timer duration it resets and logs a message
        if (timer >= timerDuration)
        {
            Debug.Log("Timer is up!"); // Log a message when the timer is complete
            timerIsRunning = false; // Stop the timer
            timer = 0f; // Reset the timer for the next time it starts
        }

        if (distance > distanceFromMouse)
        { 
        timerIsRunning = false;
        }
       
        //Debug.Log(timerIsRunning);
    }
}
