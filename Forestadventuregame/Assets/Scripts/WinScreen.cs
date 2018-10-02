using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour {

    void OnCollisionEnter2D(Collision2D collision)
     {
            //attaching this script to the protal
            //will load winscreen when player collides
            if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene("WinScreen");
        }
     }

}
