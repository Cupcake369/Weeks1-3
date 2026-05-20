// using this from sprite from https://ponkpixels.itch.io/insect-enemies/download/eyJleHBpcmVzIjoxNzc5MjI3NTAxLCJpZCI6NTYzNjY3fQ%3d%3d%2ePomVoaQcclcHWH%2fBlRN8IEUMDbA%3d

using UnityEngine;

public class Insects : MonoBehaviour
{
    public AnimationCurve curve;
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
        
        //Debug.Log(transform.localScale);
        Debug.Log(progress);
        if (progress >= timerDuration)
        {
            Debug.Log("Progress will reset"); 
            progress = 0f; // progress gets reset
        }
        transform.localScale = curve.Evaluate(progress / duration) * Vector3.one;
    }
}
