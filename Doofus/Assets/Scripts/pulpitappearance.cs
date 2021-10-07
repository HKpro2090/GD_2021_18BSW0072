using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pulpitappearance : MonoBehaviour
{
    public GameObject pulpit;
    public double spawntime = 2.5;
    public Vector3 bulletCoord = new Vector3(5,0,5);
    public float timeRemaining = 2.5f;
    public bool timerIsRunning = false;
    Vector3 prevlocation;
    void Start()
    {
        GameObject gameobject1 = Instantiate(pulpit, new Vector3(0,0,0), pulpit.transform.rotation);
        prevlocation = gameobject1.transform.position;
        timerIsRunning = true;
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
                Debug.Log("Time has run out!");
                Instantiate(pulpit, prevlocation + bulletCoord, pulpit.transform.rotation);
                prevlocation += bulletCoord;
                timeRemaining = 2.5f;
                timerIsRunning = true;
            }
        }
    }
}
