using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CutScene : MonoBehaviour
{

    public GameObject Wall;
    public GameObject Text;
    public GameObject Boss;
    public GameObject Player;
    float timer = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timer += Time.deltaTime;
            Wall.SetActive(true);
            Text.SetActive(true);
            Player.GetComponent<PlayerMovement>().enabled = false;
            Player.GetComponent<PlayerAnimationControls>().enabled = false;
            Player.GetComponent<Rigidbody2D> ().velocity = new Vector2(0,0);
            if (timer > 1.0f)
            {
                Text.SetActive(false);
                Player.GetComponent<PlayerMovement>().enabled = true;
                Player.GetComponent<PlayerAnimationControls>().enabled = false;
                Boss.SetActive(false);
            }
        }
    }
}
