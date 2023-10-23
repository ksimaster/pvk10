using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public MoveCamera moveCamera; // ������ �� ������, ������� ���������� ������

    private Button button; // ������ �� ��������� ������

    private void Start()
    {
        // �������� ������ �� ��������� ������
        button = GetComponent<Button>();

        // ����������� ����� ������ MoveToTarget() ��� ������� �� ������
        button.onClick.AddListener(moveCamera.MoveToTarget);
    }
}
