using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoImage : MonoBehaviour
{
    public GameObject Bt_ImgClose;
    public GameObject Header;
    public GameObject Text_past;
    public GameObject Text_future;

    public List<GameObject> BtList;
    public List<GameObject> ImgList;


    [Header("1_1895保台紀念館")]
    public GameObject Botton1_1;
    public GameObject Botton1_2;
    public GameObject Img1_1;
    public GameObject Img1_2;

    [Header("2_生活美學館")]
    public GameObject Botton2_1;
    public GameObject Botton2_2;
    public GameObject Img2_1;
    public GameObject Img2_2;

    [Header("5_八卦山大佛")]
    public GameObject Botton5_1;
    public GameObject Botton5_2;
    public GameObject Img5_1;
    public GameObject Img5_2;

    [Header("6_銀橋飛瀑")]
    public GameObject Botton6_1;
    public GameObject Botton6_2;
    public GameObject Img6_1;
    public GameObject Img6_2;

    [Header("12_中正公園")]
    public GameObject Botton12_1;
    public GameObject Botton12_2;
    public GameObject Img12_1;
    public GameObject Img12_2;

    [Header("13_台語文創意園區")]
    public GameObject Botton13_1;
    public GameObject Botton13_2;
    public GameObject Img13_1;
    public GameObject Img13_2;

    [Header("17_八卦山排球場")]
    public GameObject Botton17_1;
    public GameObject Botton17_2;
    public GameObject Img17_1;
    public GameObject Img17_2;

    // Start is called before the first frame update
    void Start()
    {
        Bt_ImgClose.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBotton1_1Click()
    {
        Bt_ImgClose.SetActive(true);
        Img1_1.SetActive(true);

        Botton1_1.SetActive(false);
        Botton1_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(true);
        Text_past.SetActive(false);
    }
    public void OnBotton1_2Click()
    {
        Bt_ImgClose.SetActive(true);
        Img1_2.SetActive(true);

        Botton1_1.SetActive(false);
        Botton1_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(false);
        Text_past.SetActive(true);
    }
    public void OnBotton2_1Click()
    {
        Bt_ImgClose.SetActive(true);
        Img2_1.SetActive(true);

        Botton2_1.SetActive(false);
        Botton2_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(true);
        Text_past.SetActive(false);
    }
    public void OnBotton2_2Click()
    {
        Bt_ImgClose.SetActive(true);
        Img2_2.SetActive(true);

        Botton2_1.SetActive(false);
        Botton2_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(false);
        Text_past.SetActive(true);
    }
    public void OnBotton5_1Click()
    {
        Bt_ImgClose.SetActive(true);
        Img5_1.SetActive(true);

        Botton5_1.SetActive(false);
        Botton5_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(true);
        Text_past.SetActive(false);
    }
    public void OnBotton5_2Click()
    {
        Bt_ImgClose.SetActive(true);
        Img5_2.SetActive(true);

        Botton5_1.SetActive(false);
        Botton5_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(false);
        Text_past.SetActive(true);
    }
    public void OnBotton6_1Click()
    {
        Bt_ImgClose.SetActive(true);
        Img6_1.SetActive(true);

        Botton6_1.SetActive(false);
        Botton6_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(true);
        Text_past.SetActive(false);
    }
    public void OnBotton6_2Click()
    {
        Bt_ImgClose.SetActive(true);
        Img6_2.SetActive(true);

        Botton6_1.SetActive(false);
        Botton6_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(false);
        Text_past.SetActive(true);
    }
    public void OnBotton12_1Click()
    {
        Bt_ImgClose.SetActive(true);
        Img12_1.SetActive(true);

        Botton12_1.SetActive(false);
        Botton12_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(true);
        Text_past.SetActive(false);
    }
    public void OnBotton12_2Click()
    {
        Bt_ImgClose.SetActive(true);
        Img12_2.SetActive(true);

        Botton12_1.SetActive(false);
        Botton12_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(false);
        Text_past.SetActive(true);
    }
    public void OnBotton13_1Click()
    {
        Bt_ImgClose.SetActive(true);
        Img13_1.SetActive(true);

        Botton13_1.SetActive(false);
        Botton13_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(true);
        Text_past.SetActive(false);
    }
    public void OnBotton13_2Click()
    {
        Bt_ImgClose.SetActive(true);
        Img13_2.SetActive(true);

        Botton13_1.SetActive(false);
        Botton13_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(false);
        Text_past.SetActive(true);
    }
    public void OnBotton17_1Click()
    {
        Bt_ImgClose.SetActive(true);
        Img17_1.SetActive(true);

        Botton17_1.SetActive(false);
        Botton17_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(true);
        Text_past.SetActive(false);
    }
    public void OnBotton17_2Click()
    {
        Bt_ImgClose.SetActive(true);
        Img17_2.SetActive(true);

        Botton17_1.SetActive(false);
        Botton17_2.SetActive(false);

        Header.SetActive(true);
        Text_future.SetActive(false);
        Text_past.SetActive(true);
    }
    public void OnBtImgCloseClick()
    {
        foreach (var ImgObj in ImgList)
        {
            if (ImgObj.activeSelf)
            {
                ImgObj.SetActive(false);
            }
        }

        foreach (var BtObj in BtList)
        {
            if (!BtObj.activeSelf)
            {
                BtObj.SetActive(true);
            }
        }

        Bt_ImgClose.SetActive(false);
        Header.SetActive(false);
    }
}





