using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;

    public Transform gunbarrel;

    public float speed = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float tri = Input.GetAxis("L_R_Trigger");
        if(tri < 0)
        {
            GameObject bullets = Instantiate(bullet) as GameObject;

            Vector3 force;

            force = this.gameObject.transform.forward * speed;

            bullets.GetComponent<Rigidbody>().AddForce(force);

            bullets.transform.position = gunbarrel.position;

            //Destroy(bullets, 1.0f);
        }
    }
}
