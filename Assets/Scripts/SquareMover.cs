using UnityEngine;

public class SquareMover : MonoBehaviour
{
    public Camera gameCamera;
    public float speed;
    float xMax;
    float xMin = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        xMax = Screen.width; // Get the width of the camera


    }

    // Update is called once per frame
    void Update()
    {  
        Vector3 newPosition = Camera.main.WorldToScreenPoint(transform.position); // convert the current position of the object to screen coordinates
        //newPosition.z = 0; // Set z to 0 to keep the object on the same plane

        if (newPosition.x > Screen.width)
        {
            speed *= -1f;
        }

        if (newPosition.x < Screen.width - Screen.width)
        {
            speed *= -1f;
        }

        Vector3 newPos = transform.position; // get the current position of the object in world coordinates
        newPos.x += speed; // adds speed variable every fraem to the x coordinate of the new position

        transform.position = newPos; // set the position of the object to the new position
    }
}
