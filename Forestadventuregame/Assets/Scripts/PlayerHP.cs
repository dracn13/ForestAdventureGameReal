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

    void Start()
    {
        HPText.GetComponent<Text>().text = "Health: " + HP;
        HPBar.GetComponent<Slider>().value = HP;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
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
