using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXboxPad : MonoBehaviour
{
    public float speed;

    Transform cameraTransform;
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
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
        //var cameraForward = Vector3.Scale(Camera.main.transform.forward, new Vector3(1, 0, 0)).normalized;
        //Vector3 direction = cameraForward * Input.GetAxis("Vertical_L") +
        //        Camera.main.transform.right * Input.GetAxis("Horizontal_L");

        if (hl != 0 || vl != 0)
        {
            var direction = new Vector3(hl, 0, vl);
            //Vector3 direction = cameraForward * vl + cameraTransform.right * hl;
            direction = transform.TransformDirection(direction);
            direction *= speed;
        }
        //Rスティックが倒れていれば、倒れている方向を向く
        if (hr != 0 || vr != 0)
        {
            var direction2 = new Vector3(hr, 0, vr);
            //Vector3 direction = cameraForward * vr + cameraTransform.right * hr;
            transform.localRotation = Quaternion.LookRotation(direction2);
        }
    }
}
