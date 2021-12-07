using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletlife : MonoBehaviour
{
    public float lifetime;
    private Rigidbody rb;


    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifetime);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
