using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //UI를 쓸때는 꼭 있어야 함

public class Time_Score : MonoBehaviour
{
    GameObject timeNum;
    float timeAdd =0; //시간초기값
    void Start()
    {
        this.timeNum = GameObject.Find("TimeScore_UiText");        
    }

   
    void Update()
    {
        this.timeAdd += Time.deltaTime; //시간증가
        this.timeNum.GetComponent<Text>().text = this.timeAdd.ToString("F1");
    }
}
