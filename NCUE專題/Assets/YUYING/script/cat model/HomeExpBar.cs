using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HomeExpBar : MonoBehaviour
{
    public GameObject dog;
    public GameObject cat;
    public GameObject bird;
    public Slider slider;
    public Text txtExp;

    int dogExp;
    int catExp;
    int birdExp;

    private void Start()
    {
        dogExp = PlayerPrefs.GetInt("dogExp");
        catExp = PlayerPrefs.GetInt("catExp");
        birdExp = PlayerPrefs.GetInt("birdExp");
    }

    // Update is called once per frame
    void Update()
    {
        if (dog.activeInHierarchy==true)
        {
            slider.value = dogExp;
            txtExp.text = ""+dogExp; // �e���[�Ŧr��A�O���F�� ��� �ର �r��C
        }
        else if (cat.activeInHierarchy == true)
        {
            slider.value = catExp;
            txtExp.text = "" + catExp;
        }
        else if (bird.activeInHierarchy == true)
        {
            slider.value = birdExp;
            txtExp.text = "" + birdExp;
        }
    }
}
