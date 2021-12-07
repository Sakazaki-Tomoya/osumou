using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    public float Speed;
    //public int KasokuTime = 3;

    //private Rigidbody rb = null;
    private string Buff = "Buff";
    // Start is called before the first frame update
    void Start()
    {
    }

    //private bool isKasoku = false;
    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal2");
        float inputY = Input.GetAxis("Vertical2");
        float moveX = inputX * Speed * Time.deltaTime;
        float moveY = inputY * Speed * Time.deltaTime;

        transform.Translate(moveX, 0f, moveY);
    }
}
