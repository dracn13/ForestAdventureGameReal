using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAnimation : MonoBehaviour

{
    public GameObject PlayerHat;
    public GameObject PlayerHatless;
    public RuntimeAnimatorController controller;

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerSwitch")
        {
            //PlayerHat.GetComponent<SpriteRenderer>().enabled = false;
            //PlayerHatless.SetActive(true);
            Animator a = GetComponent<Animator>();
            float x = a.GetFloat("X");
            float y = a.GetFloat("Y");

            GetComponent<Animator>().runtimeAnimatorController = controller;
        }

    }
}