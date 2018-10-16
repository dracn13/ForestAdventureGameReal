using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallAppear : MonoBehaviour
{

    public GameObject Wall;

    void OnTriggerExit2D(Collider2D collision)
    {
        Wall.SetActive(true);
    }
}
