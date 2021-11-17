using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Generator : MonoBehaviour    
{
    public GameObject 복제오브젝트;
    public float wall_Span = 0;
    public float wall_Range ;
    float time_Span = 0;
   
    void Start()
    {
        
    }  
    void Update()
    {
        this.time_Span += Time.deltaTime;
        if (this.time_Span > this.wall_Span)
        {
            this.time_Span = 0;
            GameObject wall_Clone = Instantiate(복제오브젝트);
            wall_Clone.transform.position = new Vector3(40, Random.Range(-wall_Range, wall_Range), 0);
            //go.transform.position = new Vector3(0, Random.Range(-1,1), 0);
            //Debug.Log(range);
        }
    }
}
