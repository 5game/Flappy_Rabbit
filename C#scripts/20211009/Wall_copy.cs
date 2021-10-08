using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_copy : MonoBehaviour    
{
    public GameObject wallPrefab;
    public float span = 0;
   public float range ;
    float delta = 0;
   
    void Start()
    {
        
    }  
    void Update()
    {
        this.delta += Time.deltaTime;
        if (this.delta > this.span)
        {
            this.delta = 0;
            GameObject clone = Instantiate(wallPrefab);
            clone.transform.position = new Vector3(40, Random.Range(-range, range), 0);
            //go.transform.position = new Vector3(0, Random.Range(-1,1), 0);
            //Debug.Log(range);
        }
    }
}
