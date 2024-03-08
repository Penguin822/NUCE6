using UnityEngine;
using TMPro;  // 引入 TextMeshPro 命名空间

public class Number: MonoBehaviour
{
    public TMP_Text displayText;  // 使用 TMP_Text 替代 Text
    public int initNum = 0;
    public int showNum = 0;
    public int targetNum = 100;
    public float speed = 1f;
    public ChangeType changeType = ChangeType.Linear;

    void Update()
    {
        showNum = NumberChange(initNum, showNum, targetNum, speed, changeType);

        // 在数字前添加"+"符号并应用到 TMP_Text 组件上
        displayText.text = "+" + showNum.ToString();
    }

    public static int NumberChange(int initNum, int showNum, int targetNum, float v, ChangeType changeType = ChangeType.Linear)
    {
        switch (changeType)
        {
            case ChangeType.Linear:
                showNum += Mathf.RoundToInt((targetNum - initNum) * Time.deltaTime / v);
                if (showNum >= targetNum)
                {
                    showNum = targetNum;
                }
                return showNum;
            case ChangeType.EaseIn:
                return showNum;
            case ChangeType.EaseOut:
                showNum += Mathf.RoundToInt((targetNum - showNum) * Time.deltaTime / v);
                return showNum;
            default:
                return 0;
        }
    }
}

public enum ChangeType
{
    Linear,
    EaseIn,
    EaseOut
}
