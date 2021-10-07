using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puplitblock : MonoBehaviour
{
    public float min_time_destroy = 4.0f;
    public float max_time_destroy = 5.0f;
    float timeRemaining;
    public bool timerIsRunning = false;
    public TextMeshProUGUI timer;
    // Start is called before the first frame update
    public GameObject score;
    public bool istouching = false;

    private void OnCollisionEnter(Collision collision)
    {
        score.GetComponent<pulpitappearance>().score += 1;
        Debug.Log("Safe");
    }

    void Start()
    {
        timerIsRunning = true;
        timeRemaining = Random.Range(min_time_destroy, max_time_destroy);
        timer.text = timeRemaining.ToString();
        score = GameObject.Find("ScriptObjects");
    }

    // Update is called once per frame
    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
                timer.text = timeRemaining.ToString("F1");
            }
            else
            {
                if()
                {
                    score.GetComponent<pulpitappearance>().score += 1;
                }
                Destroy(gameObject);
                timeRemaining = 0f;
                timerIsRunning = true;
            }
        }
    }
}
