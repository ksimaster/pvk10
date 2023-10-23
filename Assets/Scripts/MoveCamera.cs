using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector3 targetPosition; // �������� ����������, ���� ����� ����������� ������

    public void MoveToTarget()
    {
        // �������� ������ �� ������� ������
        Camera mainCamera = Camera.main;

        // ���������� ������ �� �������� ����������
        mainCamera.transform.position = targetPosition;
    }
}
