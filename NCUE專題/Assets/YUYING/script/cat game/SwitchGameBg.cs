using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchGameBg : MonoBehaviour
{
    //canvas
    public GameObject bgCanvas;
    public GameObject bg;

    public Sprite[] bgPast;
    public Sprite[] bgFuture;

    private int inScreenFlagID;

    private void Awake()
    {
        //inScreenFlagID = PlayerPrefs.GetInt("inScreenFlagID");
        inScreenFlagID = MainCamera.lastVisibleFlagID;
        Debug.Log("inScreenFlagID"+inScreenFlagID);
    }


    public void ClickBackAR()
    {
        bgCanvas.SetActive(false);
    }
    public void ClickPass()
    {
        Debug.Log("pass = " + inScreenFlagID);
        bgCanvas.SetActive(true);
        bg.GetComponent<Image>().sprite = bgPast[inScreenFlagID];
    }

    public void ClickFuture()
    {
        Debug.Log("future = "+inScreenFlagID);
        bgCanvas.SetActive(true);
        bg.GetComponent<Image>().sprite = bgFuture[inScreenFlagID];
    }
}
