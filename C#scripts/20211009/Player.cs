using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
    public class Player : MonoBehaviour
{
    public float jumpPower = 0;
    public AudioClip jumpSE; //20210107 추가
    public AudioClip deadSE; //20210107 추가
    AudioSource playeSE; //20210107 추가
    GameObject jumpScoreUi; //20211008추가

    void Start()
    {
        this.playeSE = GetComponent<AudioSource>(); //20210107 추가
        this.jumpScoreUi = GameObject.Find("JumpDirector"); //20211008 추가
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            //GetComponent<AudioSource>().Play(); //점프를 하면 소리가 난다.(2021.10.07추가)
            this.playeSE.PlayOneShot(this.jumpSE); //20210107 추가
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
            this.jumpScoreUi.GetComponent<JumpScore>().GetJumpPoint(); 

        }
    }
    private void OnCollisionEnter(Collision other)
    {
       //this.playeSE.PlayOneShot(this.deadSE); //20210107 추가
        SceneManager.LoadScene("GameScene");
    }
}
