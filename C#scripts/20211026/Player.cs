using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
    public class Player : MonoBehaviour
{
    public float jumpVelocity = 0; //20211015수정
    public AudioClip jumpSE; //20210107 추가
    public AudioClip deadSE; //20210107 추가
    //AudioSource playSE; //20210107 추가
    GameObject jumpNumberUi; //20211026(점프 횟수Ui) JumpDirector를 대입하기 위한 변수

    void Start()
    {
        //this.playSE = GetComponent<AudioSource>(); //20210107 추가
        this.jumpNumberUi = GameObject.Find("JumpDirector"); //20211026  Find함수(메서드)로 Hierarchy에서 게임오브젝트(JumpNum_UiText)를 찾아서jumpNumberUi변수에 대입
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump")) //점프버튼(스페이스바)를 눌렀다면
        {
            GetComponent<AudioSource>().Play(); //점프를 하면 소리가 난다.(2021.10.07추가)
            //this.playeSE.PlayOneShot(this.jumpSE); //20210107 추가
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpVelocity+Time.deltaTime, 0);//(20211019추가)
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpVelocity + Time.deltaTime, 0);
            //y축으로 jumpVelocity값 만큼 이동
            this.jumpNumberUi.GetComponent<Play_Jump>().JumpAddition(); //스크립트<Play_Jump>에 있는 .JumpAddition() 호출

        }
    }
    private void OnCollisionEnter(Collision other)
    {
       //this.playeSE.PlayOneShot(this.deadSE); //20210107 추가
        SceneManager.LoadScene("GameScene");
    }
}
