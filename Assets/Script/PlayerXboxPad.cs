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

        // ���X�e�B�b�N�̉��̌X��
        var hl = Input.GetAxis("Horizontal");

        // ���X�e�B�b�N�̏c�̌X��
        var vl = Input.GetAxis("Vertical");

        // �E�X�e�B�b�N�̉��̌X��
        var hr = Input.GetAxis("Horizontal2");

        // �E�X�e�B�b�N�̏c�̌X��
        var vr = Input .GetAxis("Vertical2");

        var cameraForward = Vector3.Scale(cameraTransform.forward, new Vector3(1, 0, 1)).normalized;

        //L�X�e�B�b�N���|��Ă���΁A�ړ�
        if (hl != 0 || vl != 0)
        {
            Vector3 direction = cameraForward * vl + cameraTransform.right * hl;
            agent.Move(direction * Time.deltaTime);
        }
        //R�X�e�B�b�N���|��Ă���΁A�|��Ă������������
        if (hr != 0 || vr != 0)
        {
            Vector3 direction = cameraForward * vr + cameraTransform.right * hr;
            transform.localRotation = Quaternion.LookRotation(direction);
        }
    }
}
