using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class pulpitappearance : MonoBehaviour
{
    public GameObject pulpit;
    public double spawntime = 2.5;
    public Vector3 bulletCoord = new Vector3(5,0,5);
    public float timeRemaining = 2.5f;
    public bool timerIsRunning = false;
    Vector3 prevlocation;
    public int score = 0;
    int option;
    public TextMeshProUGUI scorecard;
    void Start()
    {
        GameObject gameobject1 = Instantiate(pulpit, new Vector3(0,0,0), pulpit.transform.rotation);
        prevlocation = gameobject1.transform.position;
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        scorecard.text = score.ToString();
        Debug.Log(score);
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                //Debug.Log("Time has run out!");
                option = Random.Range(1, 4);
                if(option == 1)
                {
                    Instantiate(pulpit, prevlocation + new Vector3(9,0,0), pulpit.transform.rotation);
                    prevlocation += new Vector3(9, 0, 0);
                }
                if (option == 2)
                {
                    Instantiate(pulpit, prevlocation + new Vector3(0, 0, -9), pulpit.transform.rotation);
                    prevlocation += new Vector3(0, 0, -9);
                }
                if (option == 3)
                {
                    Instantiate(pulpit, prevlocation + new Vector3(-9, 0, 0), pulpit.transform.rotation);
                    prevlocation += new Vector3(-9, 0, 0);
                }
                if (option == 4)
                {
                    Instantiate(pulpit, prevlocation + new Vector3(0, 0, 9), pulpit.transform.rotation);
                    prevlocation += new Vector3(0, 0, 9);
                }
                timeRemaining = 2.5f;
                timerIsRunning = true;
            }
        }
    }
}
