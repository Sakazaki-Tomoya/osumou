using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playersub : MonoBehaviour
{
    Transform cameraTransform;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 agent;

        // 左スティックの横の傾き
        var hl = Input.GetAxis("Horizontal_L");

        // 左スティックの縦の傾き
        var vl = Input.GetAxis("Vertical_L");

        // 右スティックの横の傾き
        var hr = Input.GetAxis("Horizontal_R");

        // 右スティックの縦の傾き
        var vr = Input.GetAxis("Vertical_R");

        var cameraForward = Vector3.Scale(cameraTransform.forward, new Vector3(1, 0, 1)).normalized;

        //Lスティックが倒れていれば、移動
        if (hl != 0 || vl != 0)
        {
            Vector3 direction = cameraForward * vl + cameraTransform.right * hl;
            agent = direction * Time.deltaTime;
        }
        //Rスティックが倒れていれば、倒れている方向を向く
        if (hr != 0 || vr != 0)
        {
            Vector3 direction = cameraForward * vr + cameraTransform.right * hr;
            transform.localRotation = Quaternion.LookRotation(direction);
        }

    }
}
