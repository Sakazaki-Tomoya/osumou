using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public string paose;

    [SerializeField]
    private GameObject pauseUIPrefab;

    private GameObject pauseUIInstance;

    [SerializeField] GameObject Paose;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("joystick button 1"))
        {
            if(pauseUIInstance == null)
            {
                pauseUIInstance = GameObject.Instantiate(pauseUIPrefab) as GameObject;
                Time.timeScale = 0f;
                Paose.SetActive(true);
            }
            else
            {
                Destroy(pauseUIInstance);
                Time.timeScale = 1f;
                Paose.SetActive(false);
            }
        }

        if(Mathf.Approximately(Time.timeScale,0f))
        {
            return;
        }

    }
}
