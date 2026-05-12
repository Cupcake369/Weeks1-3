using UnityEngine;

public class alien : MonoBehaviour
{
    public float duration =3f;
    float timer;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;//basically the timer that keeps counting
        if (timer > duration)
        {
            // Move the alien to a random position within the specified range
            transform.position = new Vector3(Random.Range(-8f, 8f), Random.Range(-4f, 4f), 0);
            
            //RESET THE TIMER TO 0 AND START COUNTING AGAIN
            timer = 0;
        }

    }
}
