// using this from sprite from https://ponkpixels.itch.io/insect-enemies/download/eyJleHBpcmVzIjoxNzc5MjI3NTAxLCJpZCI6NTYzNjY3fQ%3d%3d%2ePomVoaQcclcHWH%2fBlRN8IEUMDbA%3d

using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;

public class Insects : MonoBehaviour
{
    public AnimationCurve curve;
    public AnimationCurve lerpCurve;



    public Camera gameCamera;
    public float distanceFromMouse;
    public float minDistance;
    public float maxDistance;
    public float flyMove;
    public bool isHover;
    public bool isRight;
    public float duration;
    float progress = 0f;
    public float timerDuration = 5f; // Duration of the timer in seconds
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime; // increment the progress by the time elapsed since the last frame

        //increase local scale based on the animation curve
        
        
        if (progress >= timerDuration)
        {
            
            progress = 0f; // progress gets reset
        }
        transform.localScale = curve.Evaluate(progress / duration) * Vector3.one;



        //get mouse position in world coordinates
        Vector2 currentMousePosition = gameCamera.ScreenToWorldPoint(Mouse.current.position.ReadValue());
        Vector2 currentPostion = transform.position;
        Vector2 newPos = transform.position;

        float distance = Vector2.Distance(currentMousePosition, currentPostion);
        
        if (distance < distanceFromMouse)
        {
            isHover = true;
            //Debug.Log("The mouse is close to the insect");
        }
        //else
        //{
        //    isHover = false;
        //    //Debug.Log("The mouse is far from the insect");
        //}

        if (isHover == true)
        {
            flyMove += Time.deltaTime;
            newPos.x = Mathf.Lerp(minDistance, maxDistance, lerpCurve.Evaluate(flyMove));
            
            Debug.Log(isRight);
            transform.position = newPos;
            
            //isRight = true;

        }

        if(flyMove >= 1f)
        {
            isHover = false;
            flyMove = 0f;
            minDistance = maxDistance;
            maxDistance = -minDistance;

        }
        

        //if (isHover == true && isRight == true)
        //{
        //    newPos.x = Mathf.Lerp(minDistance, maxDistance, lerpCurve.Evaluate(speed));

        //    Debug.Log(isRight);
        //    transform.position = newPos;

        //    isRight = false;

        //    //Debug.Log("The mouse is close to the insect");
        //}






    }
}
