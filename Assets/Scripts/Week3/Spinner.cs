using UnityEngine;

public class Spinner : MonoBehaviour
{
    public float rotationSpeed = 45f; // Degrees per second
    public float zMax;
    public float zMin;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

        Vector3 currentRotation = transform.eulerAngles;
        if (currentRotation.z >= zMax)
        {
            rotationSpeed *= -1f;

        }
        if (currentRotation.z >= zMin)
        {
            rotationSpeed *= -1f;

        }


        currentRotation.z += rotationSpeed * Time.deltaTime;
        transform.eulerAngles = currentRotation;
        
        //Debug.Log(currentRotation.z);


    }
}
