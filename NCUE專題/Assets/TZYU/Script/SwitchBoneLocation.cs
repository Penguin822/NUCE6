using System;
using ARLocation.UI;
using UnityEngine;
using UnityEngine.Events;

public class SwitchBoneLocation : MonoBehaviour
{
    private int inScreenFlagID;
    public GameObject[] bones;

    void Start()
    {
        inScreenFlagID = MainCamera.lastVisibleFlagID;
        Debug.Log("inScreenFlagID" + inScreenFlagID);
        SetBonesActiveState(false);
    }

    void Update()
    {
        if(inScreenFlagID == 4)
        {
            bones[0].SetActive(true);
        }
        if (inScreenFlagID == 6)
        {
            bones[1].SetActive(true);
        }
        if (inScreenFlagID == 9)
        {
            bones[2].SetActive(true);
        }
        if (inScreenFlagID == 10)
        {
            bones[3].SetActive(true);
        }
    }

    void SetBonesActiveState(bool state)
    {
        foreach (GameObject bone in bones)
        {
            bone.SetActive(state);
        }
    }
}