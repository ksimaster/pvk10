using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public MoveCamera moveCamera; // Ссылка на скрипт, который перемещает камеру

    private Button button; // Ссылка на компонент кнопки

    private void Start()
    {
        // Получаем ссылку на компонент кнопки
        button = GetComponent<Button>();

        // Настраиваем вызов метода MoveToTarget() при нажатии на кнопку
        button.onClick.AddListener(moveCamera.MoveToTarget);
    }
}
