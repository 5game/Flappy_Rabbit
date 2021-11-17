using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Move : MonoBehaviour
{
    public float wall_Translate = 0;
    void Start()
    {
        Destroy(gameObject, 10f);
    }

  
    void Update()
    {
        transform.Translate(wall_Translate * Time.deltaTime, 0, 0); //x축 좌표 이동
    }
}
