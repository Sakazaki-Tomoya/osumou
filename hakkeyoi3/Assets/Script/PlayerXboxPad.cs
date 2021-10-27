using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerXboxPad : MonoBehaviour
{
    Transform cameraTransform;
    void Start()
    {
        cameraTransform = Camera.main.transform;
    }

    void Update()
    {
        Vector3 agent;

        // ���X�e�B�b�N�̉��̌X��
        var hl = Input.GetAxis("Horizontal_L");

        // ���X�e�B�b�N�̏c�̌X��
        var vl = Input.GetAxis("Vertical_L");

        // �E�X�e�B�b�N�̉��̌X��
        var hr = Input.GetAxis("Horizontal_R");

        // �E�X�e�B�b�N�̏c�̌X��
        var vr = Input .GetAxis("Vertical_R");

        var cameraForward = Vector3.Scale(cameraTransform.forward, new Vector3(1, 0, 1)).normalized;

        //L�X�e�B�b�N���|��Ă���΁A�ړ�
        if (hl != 0 || vl != 0)
        {
            Vector3 direction = cameraForward * vl + cameraTransform.right * hl;
            agent = direction * Time.deltaTime;
        }
        //R�X�e�B�b�N���|��Ă���΁A�|��Ă������������
        if (hr != 0 || vr != 0)
        {
            Vector3 direction = cameraForward * vr + cameraTransform.right * hr;
            transform.localRotation = Quaternion.LookRotation(direction);
        }
    }
}
