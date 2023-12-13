using System.Collections;
using System.Collections.Generic;
using System.Xml.Linq;
using UnityEngine;

public class HomeAniPanel : MonoBehaviour
{
    public GameObject dog;
    public GameObject cat;
    public GameObject bird;
    public GameObject dogPanel;
    public GameObject catPanel;
    public GameObject birdPanel;

    // Update is called once per frame
    void Update()
    {
        if (dog.activeInHierarchy == true)
        {
            dogPanel.SetActive(true);
            catPanel.SetActive(false);
            birdPanel.SetActive(false);
        }
        else if (cat.activeInHierarchy == true)
        {
            dogPanel.SetActive(false);
            catPanel.SetActive(true);
            birdPanel.SetActive(false);
        }
        else if (bird.activeInHierarchy == true)
        {
            dogPanel.SetActive(false);
            catPanel.SetActive(false);
            birdPanel.SetActive(true);
        }
    }
}
