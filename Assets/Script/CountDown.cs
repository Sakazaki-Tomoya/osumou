using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CountDown : MonoBehaviour
{
    public Text timeTexts;
    public Text countDown;
    float totalTime = 63;
    int retime;
    float countdown = 3f;
    int count;
    public Player player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(countdown >= 0)
        {
            countdown -= Time.deltaTime;
            count = (int) countdown;
            countDown.text = count.ToString();
        }
        if(countdown <= 0)
        {
            countDown.text = "";
            totalTime -= Time.deltaTime;
            retime = (int)totalTime;
            timeTexts.text = retime.ToString();
            if(retime == 0)
            {
                SceneManager.LoadScene("result");
            }
        }
        if(totalTime <= 0)
        {
        }
    }
}
