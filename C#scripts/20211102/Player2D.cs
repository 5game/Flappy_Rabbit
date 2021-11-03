using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2D : MonoBehaviour
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
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, jumpPower, 0);
        }
    }
    private void OnCollisionEnter2D (Collision2D other)
    {
        SceneManager.LoadScene("GameScene");
    }
}
