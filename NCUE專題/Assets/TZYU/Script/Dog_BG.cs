using UnityEngine;
using UnityEngine.UI;

public class Dog_BG : MonoBehaviour
{
    //canvas
    public GameObject bgCanvas;
    public GameObject bg;

    public Sprite bgPast;
    public Sprite bgFuture;


    public void ClickBackAR()
    {
        bgCanvas.SetActive(false);
    }
    public void ClickPass()
    {
        bgCanvas.SetActive(true);
        bg.GetComponent<Image>().sprite = bgPast;
    }

    public void ClickFuture()
    {
        bgCanvas.SetActive(true);
        bg.GetComponent<Image>().sprite = bgFuture;
    }
}
