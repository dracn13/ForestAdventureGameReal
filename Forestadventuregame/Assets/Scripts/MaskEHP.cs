using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MaskEHP : MonoBehaviour
{


    public int EHP = 2;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            EHP--;

            if (EHP <= 0)

            {
                SceneManager.LoadScene("WinScreen");
            }
        }
    }
}
