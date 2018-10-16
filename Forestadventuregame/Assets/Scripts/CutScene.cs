using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class CutScene : MonoBehaviour
{

    public GameObject Wall;
    public GameObject Text;
    float timer = 0;

    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timer += Time.deltaTime;
            Wall.SetActive(true);
            Text.SetActive(true);
            GetComponent<PlayerMovement>().enabled = false;
            if (timer > 1.0f)
            {
                Text.SetActive(false);
                GetComponent<PlayerMovement>().enabled = true;
            }
        }
    }
}
