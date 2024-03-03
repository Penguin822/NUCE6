using System;
using ARLocation.UI;
using UnityEngine;
using UnityEngine.Events;

public class SwitchBoxLocation : MonoBehaviour
{
    private int inScreenFlagID;
    public GameObject[] boxes;

    // Start is called before the first frame update
    void Start()
    {
        inScreenFlagID = MainCamera.lastVisibleFlagID;
        Debug.Log("inScreenFlagID" + inScreenFlagID);
        SetBoxesActiveState(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(inScreenFlagID == 0)
        {
            boxes[0].SetActive(true);
        }
        if (inScreenFlagID == 2)
        {
            boxes[1].SetActive(true);
        }
        if (inScreenFlagID == 3)
        {
            boxes[2].SetActive(true);
        }
        if (inScreenFlagID == 5)
        {
            boxes[3].SetActive(true);
        }
    }

    void SetBoxesActiveState(bool state)
    {
        foreach (GameObject box in boxes)
        {
            box.SetActive(state);
        }
    }
}
