using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallDisappear : MonoBehaviour {

    public GameObject Wall;

    void OnTriggerExit2D(Collider2D collision)
    {
        Wall.SetActive(false);
    }
}
