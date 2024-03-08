using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class StartSwitch : MonoBehaviour
{
    public GameObject StartDog;
    public GameObject Main;
    public void DogStart()
    {
        SceneManager.LoadScene("¹Ï®ÑÀ]´ú¸Õ");
    }
    public void SwitchScene()
    {
        SceneManager.LoadScene("Main");
    } 
}
