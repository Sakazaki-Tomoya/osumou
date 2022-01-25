using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioClip Gunfire;
    public AudioClip ElectricWall;
    public AudioClip none1;
    public AudioClip none2;

    AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // 射撃音
        float tri = Input.GetAxis("L_R_Trigger");
        if (tri < 0)
        {
            audioSource.PlayOneShot(Gunfire);
        }
    }
    //デバフの壁
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            audioSource.PlayOneShot(ElectricWall);
        }
    }

}
