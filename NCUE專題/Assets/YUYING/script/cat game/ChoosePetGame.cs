using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChoosePetGame : MonoBehaviour
{
    public void BtnDog()
    {
        SceneManager.LoadScene("Dog_Main");
    }
    public void BtnCat()
    {
        //SceneManager.LoadScene("cat_game_intro");
        SceneManager.LoadScene("cat_gameLAR");
    }
    public void BtnBird()
    {
        SceneManager.LoadScene("B_game");
    }
}
