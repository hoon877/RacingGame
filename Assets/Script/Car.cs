using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    private int Gas = 100;

    void Awake()
    {
        
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
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        Gas += 30;
    }
}