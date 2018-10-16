using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle2 : MonoBehaviour
{

    public GameObject Dark;
    public int Buttons2 = 0;
    public GameObject Door;


    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Dark.GetComponent<SpriteRenderer>().enabled == true)
        {
            Buttons2++;
            collision.gameObject.GetComponent<ButtonCount2>().ModifyButtonCount2(1);
            Dark.GetComponent<SpriteRenderer>().enabled = false;
            Debug.Log(Buttons2);

        }
        else if (collision.gameObject.tag == "Player" && Dark.GetComponent<SpriteRenderer>().enabled == false)
        {
            Dark.GetComponent<SpriteRenderer>().enabled = true;
            Buttons2--;
            collision.gameObject.GetComponent<ButtonCount2>().ModifyButtonCount2(-1);
            Debug.Log("Door Count is" + Buttons2);
        }

    }
}


