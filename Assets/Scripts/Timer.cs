using UnityEngine;

public class Timer : MonoBehaviour
{
    public float duration;
    float progress = 0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime; // Increment the progress by the time elapsed since the last frame
        if (progress >= duration)
        {
            Debug.Log("Timer is up!"); // Log a message when the timer is complete
          
        }
    }
}
