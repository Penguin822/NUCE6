using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class Info : MonoBehaviour
{
    public GameObject panelIntro;
    public Toggle toggleDoNotShowAgain;

    private void Start()
    {
    //Time.timeScale = 0;
        if (PlayerPrefs.HasKey("DoNotShowAgain"))
        {
            panelIntro.SetActive(true);
            toggleDoNotShowAgain.isOn = true;
        }
    }
    public void ClickConfirm()
    {
        Time.timeScale = 1;       
        panelIntro.SetActive(false);       
    }

    public void ClickBackHome()
    {
        SceneManager.LoadScene("Dog_Win");
    }

    public void ClickIntro()
    {
        panelIntro.SetActive(true);
        Time.timeScale = 0;
    }

    public void ClickDoNotShowAgain()
    {
        //���A���
        if(toggleDoNotShowAgain.isOn == true)
        {
            PlayerPrefs.SetInt("DoNotShowAgain", 1);
        }

        //�����C�������
        if (toggleDoNotShowAgain.isOn == false)
        {
            PlayerPrefs.DeleteKey("DoNotShowAgain");
        }
    }
}