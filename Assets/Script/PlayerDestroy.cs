using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerDestroy : MonoBehaviour
{
    //Rigidbody rb;
    public GameObject Player;
    public GameObject Player2;
    public GameObject Timer;
    public string winner;
    [SerializeField] GameObject AWIN;
    [SerializeField] GameObject BWIN;

    public static event System.Action<bool> StopTimeEvent = delegate { };

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

        if (collision.gameObject.tag == "Player")
        {
            Destroy(Player);
            Destroy(Player2);
        }

        if (collision.gameObject == Player)
        { 
            winner = "1P WIN";
            AWIN.SetActive(true);
            void stopTime(bool isStop) 
            {
                if (StopTimeEvent != null) StopTimeEvent(isStop);
            }
        }

        if(collision.gameObject == Player2)
        {
            winner = "2P WIN";
            BWIN.SetActive(true);
            void stopTime(bool isStop)
            {
                if (StopTimeEvent != null) StopTimeEvent(isStop);
            }
        }
    }
}
