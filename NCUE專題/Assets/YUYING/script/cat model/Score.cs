using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public void ClearDogGame()
    {
        PlayerPrefs.SetInt("dogExp", PlayerPrefs.GetInt("dogExp") + 1000);
        Debug.Log("dogExp: " + PlayerPrefs.GetInt("dogExp"));
    }
    public void ClearCatGame()
    {
        PlayerPrefs.SetInt("catExp", PlayerPrefs.GetInt("catExp") + 1000);
        Debug.Log("catExp: " + PlayerPrefs.GetInt("catExp"));
    }
    public void ClearBirdGame()
    {
        PlayerPrefs.SetInt("birdExp", PlayerPrefs.GetInt("birdExp") + 1000);
        Debug.Log("birdExp: " + PlayerPrefs.GetInt("birdExp"));
    }

    public void ClearAllScore()
    {
        PlayerPrefs.SetInt("dogExp", 0);
        PlayerPrefs.SetInt("catExp", 0);
        PlayerPrefs.SetInt("birdExp", 0);
        Debug.Log("dogExp: " + PlayerPrefs.GetInt("dogExp"));
        Debug.Log("catExp: " + PlayerPrefs.GetInt("catExp"));
        Debug.Log("birdExp: " + PlayerPrefs.GetInt("birdExp"));
    }
}
