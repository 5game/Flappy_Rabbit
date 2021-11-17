using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Play_Jump : MonoBehaviour
{
    GameObject jumpNum; // JumpNum_UiText 대입하기 위한 변수
    int score = 0; //점수 초기값

    public void JumpAddition() //점프의 횟수를 계산하는 함수(메서드)
    {
        this.score += 1; //score 변수에서 점프를 할 때마다 1씩 증가(대입)시킴
    }
    void Start()
    {
        this.jumpNum = GameObject.Find("JumpNum_UiText"); //Find함수(메서드)로 Hierarchy에서 게임오브젝트(JumpNum_UiText)를 찾아서 jumpNum변수에 대입
    }

   
    void Update()
    {
        this.jumpNum.GetComponent<Text>().text = this.score.ToString(); //text Ui 에 점수 출력 ToString()함수(메서드)를 이용
    }
}
