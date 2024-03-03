using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoosePetGame : MonoBehaviour
{
    private int inScreenFlagID;

    private void Awake()
    {
        inScreenFlagID = MainCamera.lastVisibleFlagID;
        Debug.Log("inScreenFlagID" + inScreenFlagID);
    }

    public void PlayGame()
    {
        if(inScreenFlagID == 4 || inScreenFlagID == 6 || inScreenFlagID == 9 || inScreenFlagID == 10)
        {
            BtnDog();
        }
        if (inScreenFlagID == 0 || inScreenFlagID == 2 || inScreenFlagID == 3 || inScreenFlagID == 5)
        {
            BtnCat();
        }
        if (inScreenFlagID == 1 || inScreenFlagID == 7 || inScreenFlagID == 8 || inScreenFlagID == 11)
        {
            BtnBird();
        }
    }

    public void BtnDog()
    {
        SceneManager.LoadScene("Dog_Main");
    }
    public void BtnCat()
    {
        SceneManager.LoadScene("cat_game_intro");
    }
    public void BtnBird()
    {
        SceneManager.LoadScene("B_game");
    }

    public void BackToCamera()
    {
        SceneManager.LoadScene("CameraToPlayGame");
    }
}
