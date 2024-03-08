using System.Collections;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public int m_seconds;
    public int m_min;
    public int m_sec;

    public TMP_Text m_display;  // 使用 TMP_Text 替代 Text

    // 使用靜態變數保存唯一的實例
    private static EndGame instance;

    void Awake()
    {
        // 如果實例不存在，設置它為這個物件
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            // 如果實例已存在，銷毀這個物件
            Destroy(gameObject);
        }

        StartCoroutine(MyModifiedCountdown());
    }

    IEnumerator MyModifiedCountdown()
    {
        m_display.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));
        m_seconds = (m_min * 60) + m_sec;

        while (m_seconds > 0)
        {
            yield return new WaitForSeconds(1);

            m_seconds--;
            m_sec--;

            if (m_sec < 0 && m_min > 0)
            {
                m_min -= 1;
                m_sec = 59;
            }
            else if (m_sec < 0 && m_min == 0)
            {
                m_sec = 0;
            }

            m_display.text = string.Format("{0}:{1}", m_min.ToString("00"), m_sec.ToString("00"));
        }

        yield return new WaitForSeconds(1);

        // 在這裡你可以切換到新的場景，並保留計時器的數值
        SceneManager.LoadScene("Main");
    }
}
