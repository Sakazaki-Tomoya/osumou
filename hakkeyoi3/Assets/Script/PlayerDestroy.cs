using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDestroy : MonoBehaviour
{
    //Rigidbody rb;
    //public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        //rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    { 
    }
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log("衝突したオブジェクト：" + gameObject.name);
        Debug.Log("衝突されたオブジェクト：" + collision.gameObject.name);

        Destroy(collision.gameObject);

    }
}
