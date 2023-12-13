using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomePetBtnTips : MonoBehaviour
{
    public GameObject panel_tips;
    public GameObject text_1000;
    public GameObject text_2000;

    private void Start()
    {
        panel_tips.SetActive(false);
        text_1000.SetActive(false);
        text_2000.SetActive(false);
    }

    public void BtnClickTipActive_1000(Button btn)
    {
        if (btn.interactable == false)
        {
            panel_tips.SetActive(true);
            text_2000.SetActive(false);
            text_1000.SetActive(true);
            Invoke(nameof(HideTips), 3);
        }
    }
    public void BtnClickTipActive_3500(Button btn)
    {
        if (btn.interactable == false)
        {
            panel_tips.SetActive(true);
            text_1000.SetActive(false);
            text_2000.SetActive(true);
            Invoke(nameof(HideTips), 3);
        }
    }

    void HideTips()
    {
        panel_tips.SetActive(false);
        text_1000.SetActive(false);
        text_2000.SetActive(false);
    }
}
