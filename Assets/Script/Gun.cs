using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bullet;

    public Transform gunbarrel;

    public float speed;

    private float timeBetweenShot = 0.35f;

    private float timer;

    float countdown = 3f;

    int count;

    public AudioClip sound1;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int)countdown;
        }

        timer += Time.deltaTime;

        if(countdown <= 0) { 
        float tri = Input.GetAxis("L_R_Trigger");
            if (bullet != null)
            {

                if (tri < 0 && timer > timeBetweenShot)
                {
                    timer = 0.0f;

                    GameObject bullets = (GameObject)Instantiate(bullet, gunbarrel.position, gunbarrel.transform.rotation);
                    Rigidbody bulletRb = bullets.GetComponent<Rigidbody>();
                    bulletRb.AddForce(transform.forward * speed);
                }
            }
        }
    }
}