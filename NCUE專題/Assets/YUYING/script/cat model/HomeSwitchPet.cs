using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeSwitchPet : MonoBehaviour
{
    public GameObject dog;
    public GameObject cat;
    public GameObject bird;
    public GameObject dogPanel;
    public GameObject catPanel;
    public GameObject birdPanel;

    private void Start()
    {
        dog.SetActive(true);
        cat.SetActive(false);
        bird.SetActive(false);
        dogPanel.SetActive(true);
        catPanel.SetActive(false);
        birdPanel.SetActive(false);
    }

    public void BtnDog()
    {
        dog.SetActive(true);
        cat.SetActive(false);
        bird.SetActive(false);
        dogPanel.SetActive(true);
        catPanel.SetActive(false);
        birdPanel.SetActive(false);
    }
    public void BtnCat()
    {
        dog.SetActive(false);
        cat.SetActive(true);
        bird.SetActive(false);
        dogPanel.SetActive(false);
        catPanel.SetActive(true);
        birdPanel.SetActive(false);
    }
    public void BtnBird()
    {
        dog.SetActive(false);
        cat.SetActive(false);
        bird.SetActive(true);
        dogPanel.SetActive(false);
        catPanel.SetActive(false);
        birdPanel.SetActive(true);
    }
}
