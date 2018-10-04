using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonCount : MonoBehaviour {
    public int BCount = 0;
    public GameObject HideDoor;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (BCount >= 12)
        {
            HideDoor.SetActive(false);
        }else
            {
            HideDoor.SetActive(true);
        }
	}
    public void ModifyButtonCount(int mod)
    {
        BCount += mod;
    }
    
}
