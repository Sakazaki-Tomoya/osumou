using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebuffWall : MonoBehaviour
{
    private Player player;
    private PlayerXboxPad xbox;
    private Player2 player2;
    private Xbox2 xbox2;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            //Playerの動きを司るスクリプトをオフにする
            player = collision.gameObject.GetComponent<Player>();
            xbox = collision.gameObject.GetComponent<PlayerXboxPad>();
            player2 = collision.gameObject.GetComponent<Player2>();
            xbox2 = collision.gameObject.GetComponent<Xbox2>();
            player.enabled = false;
            xbox.enabled = false;
            player2.enabled = false;
            xbox2.enabled = false;

            //二秒後にPlayerが動けるようにする
            Invoke("StopOff", 2.0f); 
        }

    }

    void StopOff()
    {
        player.enabled = true;
        xbox.enabled = true;
        player2.enabled = true;
        xbox2.enabled = true;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
}
