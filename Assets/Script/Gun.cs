using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;

    public Transform gunbarrel;

    public float speed = 100;

    private float shotInterval;

    private Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }


    // Update is called once per frame
    void Update()
    {
        float tri = Input.GetAxis("L_R_Trigger");
        if (bullet != null)
        {
            shotInterval += 30;

            if (tri < 0)
            {
                GameObject bullets = (GameObject)Instantiate(bullet);

                Vector3 force;

                force = this.gameObject.transform.forward * speed;

                bullets.GetComponent<Rigidbody>().AddForce(force);

                bullets.transform.position = gunbarrel.position;
            }
        }
    }
}
