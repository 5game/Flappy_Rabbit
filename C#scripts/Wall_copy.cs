using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_copy : MonoBehaviour    
{
    public GameObject wallPrefab;
    public float span = 0;
    public float range = 0;
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
            GameObject go = Instantiate(wallPrefab) as GameObject;
            //go.transform.position = new Vector3(0, Random.Range(-range, range), 0);
            
        }
    }
}
