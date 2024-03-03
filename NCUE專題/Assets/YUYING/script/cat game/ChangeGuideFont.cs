using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ChangeGuideFont : MonoBehaviour
{
    public TMP_FontAsset newFont; // 新的字型

    void Update()
    {
        // 尋找場景中所有的 TMP_Text 元件
        TMP_Text[] allTMPTextComponents = FindObjectsOfType<TMP_Text>();

        foreach (TMP_Text textComponent in allTMPTextComponents)
        {
            // 檢查 textComponent 是否符合需要更改字型的條件
            // 這裡你可以添加其他的條件檢查，比如根據文字內容等
            if (textComponent.name == "DirectionsLabel") // 或者可以使用其他的條件來檢查
            {
                // 更改 TextMeshPro 元件的字型
                textComponent.font = newFont;
            }
        }
    }
}
