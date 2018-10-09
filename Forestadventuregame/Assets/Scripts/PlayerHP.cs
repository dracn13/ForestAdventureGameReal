using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public int HP = 10;
    public Text HPText;
    public Slider HPBar;
    float timer = 0;

     void Update()
    {
        timer += Time.deltaTime;
    }
    void Start()
    {
        HPText.GetComponent<Text>().text = "Health: " + HP;
        HPBar.GetComponent<Slider>().value = HP;
    }

   

    void OnCollisionStay2D(Collision2D collision)
    {
        if (timer > 0.5f && collision.gameObject.tag == "Enemy")
            {
            timer = 0;
            HP--;
            HPText.GetComponent<Text>().text = "Health: " + HP;
            HPBar.GetComponent<Slider>().value = HP;
            if (HP <= 0)

            {
                //Reload the level
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
        }
    }


}
