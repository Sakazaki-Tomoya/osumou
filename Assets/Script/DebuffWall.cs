using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffWall : MonoBehaviour
{
    private PlayerXboxPad player;
    private Player2 player2;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //Playerの動きを司るスクリプトをオフにする
            player = collision.gameObject.GetComponent<PlayerXboxPad>();
            player.enabled = false;

            //二秒後にPlayerが動けるようにする
            Invoke("StopOff", 2.0f); 
        }

    }

    void StopOff()
    {
        player.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        void OnCollisionEnter(Collider other)
        {
            Debug.Log("しびれた！");
        }
    }
}
