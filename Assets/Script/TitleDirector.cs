using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleDirector : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    public void Update()
    {
        //Aを押したときにGameSceneに変わる
        if(Input.GetKeyDown("joystick button 0"))
        {
            SceneManager.LoadScene("GameScene");
        }
        //if (Input.GetKeyDown("Mouce Botton 0"))
        //{
        //    SceneManager.LoadScene("GameScene");
        //}
    }
}
