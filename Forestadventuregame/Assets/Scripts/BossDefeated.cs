using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossDefeated : MonoBehaviour {

    public int EHP;
    public GameObject DoorExit;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Bullet")
        {
            EHP--;
            if (EHP <= 0)
                {
                Destroy(gameObject);
                DoorExit.SetActive(false);
            }
        }
    }
}
