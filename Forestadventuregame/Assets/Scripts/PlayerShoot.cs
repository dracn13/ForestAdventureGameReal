using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{

    public GameObject prefab;
    public float shootSpeed = 10;
    float timer = 0;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetButton("Fire1") && timer > 0.3f)
        {
            timer = 0;
            var mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
            mousePosition.z = 0;
            Vector3 shootDir = mousePosition - transform.position;
            shootDir.Normalize();
            Vector3 offset = shootDir;
            shootDir = shootDir * shootSpeed;
            //when calculating a vector from a to b
            //always do destination - start position
            GameObject Bullet = (GameObject)Instantiate(prefab, transform.position + offset, Quaternion.identity);
            Bullet.GetComponent<Rigidbody2D>().velocity = shootDir;
            Destroy(Bullet, 0.5f);
        }
    }
}

