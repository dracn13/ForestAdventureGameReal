using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class WallAppear : MonoBehaviour {

    public GameObject Wall;
    public GameObject Text;
    float timer = 0;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Wall.SetActive(true);
        Text.SetActive(true);
    }
	
}
