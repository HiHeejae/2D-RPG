using UnityEngine;
using UnityEngine.UI;

public class Playtime : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isTimerRunning;

    void Start()
    {
        // 게임 시작 시 타이머를 00:01로 초기화하고 시작
        startTime = 1f;
        isTimerRunning = true;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            // 게임이 시작되고 타이머가 계속 실행되도록 함
            float currentTime = Time.time - startTime;
            string minutes = ((int)currentTime / 60).ToString("00");
            string seconds = (currentTime % 60).ToString("00");

            // 텍스트 업데이트
            timerText.text = minutes + ":" + seconds;
        }
    }
}
