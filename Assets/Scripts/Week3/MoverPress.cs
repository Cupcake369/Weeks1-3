using UnityEngine;
using UnityEngine.InputSystem;

public class MoverPress : MonoBehaviour
{
    public float rotationSpeed = 60f;
    public float moveSpeed = 5f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        bool isUpKeyPressed = Keyboard.current.upArrowKey.isPressed;
        bool isdownKeyPressed = Keyboard.current.downArrowKey.isPressed;
        bool isLeftKeyPressed = Keyboard.current.leftArrowKey.isPressed;
        bool isRightKeyPressed = Keyboard.current.rightArrowKey.isPressed;

        if (isUpKeyPressed) { 
         transform.position += moveSpeed * Time.deltaTime * transform.up;


        }

        if (isdownKeyPressed)
        {
            transform.position -= moveSpeed * Time.deltaTime * transform.up;


        }




        if (isLeftKeyPressed == true)
        {
            transform.eulerAngles += moveSpeed * Time.deltaTime * transform.forward;

        }
        if (isRightKeyPressed == true)
        {
            transform.eulerAngles -= moveSpeed * Time.deltaTime * transform.forward;

        }


      

    }
}
