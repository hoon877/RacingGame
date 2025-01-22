using System;
using System.Collections;
using System.Collections.Generic;
using Cysharp.Threading.Tasks;
using UnityEngine;
using TMPro;

public class Car : MonoBehaviour
{
    private int Gas = 100;
    public TMP_Text GasText;

    private bool isConsumingGas = true; // Gas 감소 플래그

    void Start()
    {
        UpdateGasText(); // 초기 Gas 값을 UI에 표시
        ConsumeGas(); // Gas 감소 시작
    }

    private async void ConsumeGas()
    {
        while (isConsumingGas)
        {
            if (Gas > 0)
            {
                Gas -= 10; // Gas 감소
                UpdateGasText(); // UI 갱신
            }

            // Gas 값 감소 후 1초 대기
            await UniTask.Delay(1000);
        }
    }

    void Update()
    {
        // 마우스 입력 처리
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePosition = Input.mousePosition;

            // 화면 왼쪽 클릭 시 왼쪽으로 이동
            if (mousePosition.x < Screen.width / 2)
            {
                transform.position += Vector3.left * Time.deltaTime * 3f;
            }
            // 화면 오른쪽 클릭 시 오른쪽으로 이동
            else if (mousePosition.x > Screen.width / 2)
            {
                transform.position += Vector3.right * Time.deltaTime * 3f;
            }
        }

        if (Gas <= 0)
        {
            Time.timeScale = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Gas += 30; // 충돌 시 Gas 증가
        UpdateGasText(); // UI 갱신
    }

    private void UpdateGasText()
    {
        // UI 텍스트에 Gas 값 표시
        GasText.text = "Gas: " + Gas.ToString();
    }
}