using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play_Jump : MonoBehaviour
{
    GameObject jumpNum; //
    int score = 0;

    public void JumpAddition()
    {
        this.score += 1;
    }
    void Start()
    {
        this.jumpNum = GameObject.Find("JumpNum_UiText");
    }

   
    void Update()
    {
        this.jumpNum.GetComponent<Text>().text = this.score.ToString(); //text Ui 에 점수 출력
    }
}
