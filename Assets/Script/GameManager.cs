using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject StartPanel; // Panel을 참조하기 위한 변수
    public GameObject EndPanel;
    public void GameStart()
    {
        Time.timeScale = 1;  // 게임 시간 시작
        StartPanel.SetActive(false);  // Panel을 비활성화
    }

    public void ReStart()
    {
        Time.timeScale = 1;
        EndPanel.SetActive(false);
    }
}
