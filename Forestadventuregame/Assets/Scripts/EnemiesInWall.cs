using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesInWall : MonoBehaviour {
    public GameObject Wall;
    public GameObject Enemy;
    public GameObject Enemy2;
    public GameObject Wall2;
    float timer = 0;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      
    }
    void OnTriggerStay2D(Collider2D collision)
    {
        timer += Time.deltaTime;
        if (timer >=10)
            {
            Wall.SetActive(false);
            Enemy.SetActive(true);
            
        }
        if (timer >= 15)
        {
            Wall2.SetActive(false);
            Enemy2.SetActive(true);
        }
    }
}
