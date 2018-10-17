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
		if (timer >= 10)
        {
            Slime.SetActive(true);
        }
        if (timer >= 17)
        {
            Skeleton.SetActive(true);
        }
        if (timer >= 22)
        {
            Slime2.SetActive(true);
                Skeleton2.SetActive(true);
        }
        if (timer >= 30)
        {
            Onion.SetActive(true);

        }
        if (timer >= 40)
        {
            SkeletonBoss.SetActive(true);
        }
	}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            timer += Time.deltaTime;
        }

    }
}
