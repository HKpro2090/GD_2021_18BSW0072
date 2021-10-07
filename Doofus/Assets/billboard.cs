using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class billboard : MonoBehaviour
{
    public Transform cam;
    void Start()
    {
        cam = GameObject.Find("Main Camera").transform;
    }
    void LateUpdate()
    {
        transform.LookAt(transform.position + cam.forward);
    }
}
