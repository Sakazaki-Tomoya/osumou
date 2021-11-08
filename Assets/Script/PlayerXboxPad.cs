using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PlayerXboxPad : MonoBehaviour
{
    Transform cameraTransform;
    NavMeshAgent agent = null;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {

        // 左スティックの横の傾き
        var hl = Input.GetAxis("Horizontal");

        // 左スティックの縦の傾き
        var vl = Input.GetAxis("Vertical");

        // 右スティックの横の傾き
        var hr = Input.GetAxis("Horizontal2");

        // 右スティックの縦の傾き
        var vr = Input .GetAxis("Vertical2");

        var cameraForward = Vector3.Scale(cameraTransform.forward, new Vector3(1, 0, 1)).normalized;

        //Lスティックが倒れていれば、移動
        if (hl != 0 || vl != 0)
        {
            Vector3 direction = cameraForward * vl + cameraTransform.right * hl;
            agent.Move(direction * Time.deltaTime);
        }
        //Rスティックが倒れていれば、倒れている方向を向く
        if (hr != 0 || vr != 0)
        {
            Vector3 direction = cameraForward * vr + cameraTransform.right * hr;
            transform.localRotation = Quaternion.LookRotation(direction);
        }
    }
}
