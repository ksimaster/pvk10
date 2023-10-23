using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public Vector3 targetPosition; // «аданные координаты, куда нужно переместить камеру

    public void MoveToTarget()
    {
        // ѕолучаем ссылку на главную камеру
        Camera mainCamera = Camera.main;

        // ѕеремещаем камеру на заданные координаты
        mainCamera.transform.position = targetPosition;
    }
}
