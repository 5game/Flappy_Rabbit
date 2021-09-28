using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    
    public class Player : MonoBehaviour
{
    public float jumpPower = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        { 
            GetComponent<Rigidbody>().velocity = new Vector3(0, jumpPower, 0);
        }
    }
    private void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("GameScene");
    }
}
