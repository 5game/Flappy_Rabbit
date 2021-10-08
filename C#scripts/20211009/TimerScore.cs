using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScore : MonoBehaviour
{
    GameObject timer;
    float time =0;
    void Start()
    {
        this.timer = GameObject.Find("TimeScore");        
    }

   
    void Update()
    {
        this.time += Time.deltaTime;
        this.timer.GetComponent<Text>().text = this.time.ToString("F1");
    }
}
