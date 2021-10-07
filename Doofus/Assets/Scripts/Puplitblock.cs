using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puplitblock : MonoBehaviour
{
    public float min_time_destroy = 4.0f;
    public float max_time_destroy = 5.0f;
    float timeRemaining;
    public bool timerIsRunning = false;
    // Start is called before the first frame update
    void Start()
    {
        timerIsRunning = true;
        timeRemaining = Random.Range(min_time_destroy, max_time_destroy);
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Destroy(gameObject);
                timeRemaining = 0f;
                timerIsRunning = true;
            }
        }
    }
}
