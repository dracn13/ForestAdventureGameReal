using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAnimationControl : MonoBehaviour {
 
    // Use this for initialization
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        // which direction they are going
        Vector3 velocity = GetComponent<Rigidbody2D>().velocity;
        // declare x and y ( different from parameters (X and Y)
        float x = velocity.x;
        float y = velocity.y;
        // shows which one is more and uses that animation
        if(Mathf.Abs(x) > Mathf.Abs(y))
        {
            GetComponent<Animator>().SetFloat("X", x);
            GetComponent<Animator>().SetFloat("Y", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }else if(Mathf.Abs(x) < Mathf.Abs(y))
        {
            GetComponent<Animator>().SetFloat("Y", y);
            GetComponent<Animator>().SetFloat("X", 0);
            GetComponent<Animator>().SetBool("Idle", false);
        }
        // if your velocity x and y is =0 then the parameters(controls animations) should be set to 0 for idle animation
        else if(x == 0 && y == 0)
        {
            GetComponent<Animator>().SetBool("Idle", true);
            GetComponent<Animator>().SetFloat("Y", 0);
            GetComponent<Animator>().SetFloat("X", 0);
        }
    }
}
