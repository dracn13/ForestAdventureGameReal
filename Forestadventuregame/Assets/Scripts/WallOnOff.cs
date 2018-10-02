using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallOnOff : MonoBehaviour {

    public GameObject Wall;

    void OnTriggerEnter2D(Collider2D collision)
    {
        Wall.SetActive(true);
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Wall.SetActive(false);
    }

}
