using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Puzzle : MonoBehaviour {

    public GameObject Dark;
    public int Buttons = 0;
    public GameObject Door;
 
   
	// Use this for initialization

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && Dark.GetComponent<SpriteRenderer>().enabled == true)
        {
            Dark.GetComponent<SpriteRenderer>().enabled = false;
            Buttons++;

        }
        else if (collision.gameObject.tag == "Player" && Dark.GetComponent<SpriteRenderer>().enabled == false)
        {
            Dark.GetComponent<SpriteRenderer>().enabled = true;
            Buttons--;
            Debug.Log (Buttons);
        }
        if (Buttons >= 11)
            {
            Door.SetActive(false);
        }
    }
}

