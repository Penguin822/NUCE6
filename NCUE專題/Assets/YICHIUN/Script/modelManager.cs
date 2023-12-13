using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class modelManager : MonoBehaviour
{
    public GameObject Model1;
    public GameObject Model2;
    public GameObject Model3;
    public GameObject Model4;
    public Button action1;
    public Button action2;
    public Button action3;
    public Button action4;
    int birdExp;

    // Start is called before the first frame update
    void Start()
    {
        birdExp = PlayerPrefs.GetInt("birdExp");

        if (birdExp <= 1000)
        {
            action1.interactable = true;
            action2.interactable = true;
            action3.interactable = false;
            action4.interactable = false;
        }
        if (birdExp > 1000 && birdExp <= 2000)
        {
            action1.interactable = true;
            action2.interactable = true;
            action3.interactable = true;
            action4.interactable = false;
        }
        if (birdExp > 2000)
        {
            action1.interactable = true;
            action2.interactable = true;
            action3.interactable = true;
            action4.interactable = true;
        }
    }

    public void OnModel1Click()
    {
        Model1.SetActive(true);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(false);
    }
    public void OnModel2Click()
    {
        Model1.SetActive(false);
        Model2.SetActive(true);
        Model3.SetActive(false);
        Model4.SetActive(false);
    }
        public void OnModel3Click()
    {
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(true);
        Model4.SetActive(false);
    }
        public void OnModel4Click()
    {
        Model1.SetActive(false);
        Model2.SetActive(false);
        Model3.SetActive(false);
        Model4.SetActive(true);
    } 
}
