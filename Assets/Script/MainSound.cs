using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSound : MonoBehaviour
{
    public bool DontDestroyEnabled = true;
    // Start is called before the first frame update
    void Start()
    {
        //Sceneを遷移してもオブジェクトが消えないようにする
        if (DontDestroyEnabled)
        {
            DontDestroyOnLoad(this);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
