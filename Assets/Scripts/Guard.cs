using UnityEngine;

public class Guard : MonoBehaviour
{
    public Vector3 startValue;
    public Vector3 endValue;

    public Vector3 currentValue;

    public float duration;

    float progress;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        progress += Time.deltaTime;

        //Lerping 
        //when progress reaches endvalue it stops lerping and current value becomes end value
        //this is for numbers/float
        //currentValue = Mathf.Lerp(startValue, endValue, progress / duration); // / duration says how much time it takes to reach end value

        currentValue = Vector3.Lerp(startValue, endValue, progress / duration);
        //Debug.Log("progress: "+progress+"");
        transform.position = currentValue;

        if (progress > duration) 
        {
            progress = 0f;
        }
        Debug.Log(currentValue);
    }
}
