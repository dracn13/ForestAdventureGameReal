using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemiesSpawn : MonoBehaviour {
    float timer = 0;
    public GameObject Slime;
    public GameObject Skeleton;
    public GameObject Skeleton2;
        public GameObject Slime2;
    public GameObject Onion;
    public GameObject SkeletonBoss;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
      

    }
    void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player") 

        {
            Debug.Log("Hi");
            timer += Time.deltaTime;
            
        }
        if (timer >= 10 && timer <= 14)
        {
            Slime.SetActive(true);
        }
        if (timer >= 17 && timer <= 21)
        {
            Skeleton.SetActive(true);
        }
        if (timer >= 22 && timer <= 26 )
        {
            Slime2.SetActive(true);
            Skeleton2.SetActive(true);
        }
        if (timer >= 28 && timer <=32)
        {
            Onion.SetActive(true);

        }
        if (timer >= 34 && timer <= 38)
        {
            SkeletonBoss.SetActive(true);
        }

    }
}
