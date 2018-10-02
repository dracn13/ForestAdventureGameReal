using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAppear : MonoBehaviour {

    public GameObject Wall;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Wall.SetActive(true);
    }
	
}
