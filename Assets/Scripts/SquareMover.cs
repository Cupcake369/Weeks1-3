using UnityEngine;

public class SquareMover : MonoBehaviour
{
    public float speed = 0.01f;
    public float xMax = 5f;
    public float xMin = -5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
      

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPosition = transform.position;
        newPosition.x += speed;
        transform.position = newPosition;
        if (transform.position.x > xMax)
        {
            speed = -speed;
        }

        if (transform.position.x < xMin)
        {
            speed = -speed;
        }
    }
}
