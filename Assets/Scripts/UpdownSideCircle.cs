using UnityEngine;

public class UpdownSideCircle : MonoBehaviour
{
    float speed = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    //Not correct wait not done yet type shit
    // Update is called once per frame
    void Update()
    {

        Vector3 newPosition = transform.position;
        newPosition.y += speed * Time.deltaTime; // Move up
        newPosition.x += speed * Time.deltaTime; // Move right

        if (newPosition.x > Screen.width) {
            newPosition.x -= speed;


        }
        if (newPosition.y > Screen.height)
        {
            newPosition.y -= speed;

        }




        transform.position = newPosition;
         
    }
}
