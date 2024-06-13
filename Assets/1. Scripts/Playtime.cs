using UnityEngine;
using UnityEngine.UI;

public class Playtime : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isTimerRunning;

    void Start()
    {
        // ���� ���� �� Ÿ�̸Ӹ� 00:01�� �ʱ�ȭ�ϰ� ����
        startTime = 1f;
        isTimerRunning = true;
    }

    void Update()
    {
        if (isTimerRunning)
        {
            // ������ ���۵ǰ� Ÿ�̸Ӱ� ��� ����ǵ��� ��
            float currentTime = Time.time - startTime;
            string minutes = ((int)currentTime / 60).ToString("00");
            string seconds = (currentTime % 60).ToString("00");

            // �ؽ�Ʈ ������Ʈ
            timerText.text = minutes + ":" + seconds;
        }
    }
}
