using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Puzzle1 : MonoBehaviour {

    public GameObject Dark;
    public int Buttons2 = 0;
    public GameObject Door;
    public GameObject Player;


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
        if ( collision.gameObject.tag == "Boss" && Dark.GetComponent<SpriteRenderer>().enabled == true)
        {
            Buttons2++;
           Player.gameObject.GetComponent<ButtonCount2>().ModifyButtonCount2(1);
            Dark.GetComponent<SpriteRenderer>().enabled = false;
            Debug.Log(Buttons2);

        }
        

    }
    void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Boss" && Dark.GetComponent<SpriteRenderer>().enabled == false)

        {
            Dark.GetComponent<SpriteRenderer>().enabled = true;
            Buttons2--;
           Player.gameObject.GetComponent<ButtonCount2>().ModifyButtonCount2(-1);
            Debug.Log("Door Count is" + Buttons2);
        }
    }
}

