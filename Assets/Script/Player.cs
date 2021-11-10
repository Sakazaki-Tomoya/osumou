using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed;
    public int KasokuTime = 3;

    private Rigidbody rb = null;
    private string Buff = "Buff";
    // Start is called before the first frame update
    void Start()
    {
    }

    private bool isKasoku = false;
    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputZ = Input.GetAxis("Vertical");
        float moveX = inputX * moveSpeed * Time.deltaTime;
        //float moveZ = inputZ * moveSpeed * Time.deltaTime;

        transform.Translate(moveX, 0f, 0f);

        //        if(isKasoku == true)
        //        {
        //            rb.velocity = new Vector3(moveX*4, 0f, moveZ*4);
        //        }
        //        else if(isKasoku==false)
        //        {
        //            rb.velocity = new Vector3(moveX, 0f, moveZ);
        //        }
    }

    //    IEnumerator Kasoku()
    //    {
    //        isKasoku = true;//加速フラグがtrueになる
    //        yield return new WaitForSeconds(KasokuTime);
    //        isKasoku = false;
    //    }

    //    private void OnCollisionEnter(Collision collision)
    //    {
    //        if(collision.gameObject.tag == Buff)
    //        {
    //            StartCoroutine(Kasoku());
    //            Debug.Log("加速！");
    //        }
    //    }
}
