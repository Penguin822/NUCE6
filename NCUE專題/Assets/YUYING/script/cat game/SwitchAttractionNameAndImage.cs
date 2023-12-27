using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwitchAttractionNameAndImage : MonoBehaviour
{
    public GameObject image;
    private int inScreenFlagID;
    public Sprite[] AttractionImage;
    public GameObject[] AttractionName;

    // Start is called before the first frame update
    void Start()
    {
        inScreenFlagID = MainCamera.lastVisibleFlagID;
        Debug.Log("inScreenFlagID" + inScreenFlagID);

        for (int i = 0; i<12; i++)
        {
            AttractionName[i].SetActive(false);
        }
    }

    void Update()
    {
        image.GetComponent<Image>().sprite = AttractionImage[inScreenFlagID];
        AttractionName[inScreenFlagID].SetActive(true);
    }
}
