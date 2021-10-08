using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class JumpScore : MonoBehaviour
{
    GameObject jumpPoint;
    int score = 0;

    public void GetJumpPoint()
    {
        this.score += 1;
    }
    void Start()
    {
        this.jumpPoint = GameObject.Find("JumpScore");
    }

   
    void Update()
    {
        this.jumpPoint.GetComponent<Text>().text = this.score.ToString();
    }
}
