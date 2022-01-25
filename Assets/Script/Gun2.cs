using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun2 : MonoBehaviour
{
    public GameObject bullet2;

    public Transform gunbarrel2;

    public float speed = 100;

    private float shotInterval;

    private Rigidbody rb;

    float countdown = 3f;

    int count;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
        }
        if (countdown <= 0)
        {
            float tri = Input.GetAxis("L_R_Trigger2");
            if (bullet2 != null)
            {
                shotInterval += 1;

                if (tri < 0)
                {
                    GameObject bullets = (GameObject)Instantiate(bullet2, gunbarrel2.position, gunbarrel2.transform.rotation);
                    Rigidbody bulletRb = bullets.GetComponent<Rigidbody>();
                    bulletRb.AddForce(transform.forward * speed);
                }
            }
        }
    }
}