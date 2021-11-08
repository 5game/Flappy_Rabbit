using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NonplayerAi : MonoBehaviour
{
    public float ai_speed = 0;
    public float ai_JumpPower = 0;

    void Update()
    {
       
         //GetComponent<Rigidbody2D>().velocity = new Vector3(0, ai_JumpPower, 0);
     
    }
        //void OnCollisionExit2D(UnityEngine.Collision2D collision) //유니티5 때 문법
   void OnTriggerEnter2D (Collider2D collision)
    { 
    
        if (collision.gameObject.CompareTag("Top"))
        {
            transform.Translate(0, -ai_speed * Time.deltaTime, 0);
            Debug.Log("Top트리거");
        }
        if (collision.gameObject.CompareTag("Down"))
        {
            transform.Translate(0, ai_speed * Time.deltaTime, 0);
            Debug.Log("Down트리거");
        }       
     
    }
}
