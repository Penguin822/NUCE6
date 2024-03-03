using ARLocation;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class cat_WalkToBox_LocationVer : MonoBehaviour
{
    public GameObject cat;
    public GameObject box;
    public GameObject btn;
    public GameObject ARCam;
    public GameObject panelWarn;

    Animator catAnimator;

    // Start is called before the first frame update
    void Start()
    {
        //cat anim
        catAnimator = cat.GetComponent<Animator>();
        catAnimator.SetBool("walk", true);

        btn.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        var arCamDistance = cat.transform.position.z - ARCam.transform.position.z;

        //cat translate
        if(MoveAlongPath.moveEnd == false)
        {           
            if (Mathf.Abs(arCamDistance) > 1000f) // 原設定為2，為方便測試先調很大
            {   
                GameObject.Find("cat container").GetComponent<MoveAlongPath>().Pause();            
                catAnimator.SetBool("walk", false);
                panelWarn.SetActive(true);
            }

            if (Mathf.Abs(arCamDistance) <= 1000f) //原設定為2，為方便測試先調很大
            {
                GameObject.Find("cat container").GetComponent<MoveAlongPath>().Play();
                panelWarn.SetActive(false);
                catAnimator.SetBool("walk", true);
            }        
        }
        else
        {
            catAnimator.SetBool("walk", false);
            btn.SetActive(true);
        }
    }

    public void ClickOpen()
    {
        Destroy(GameObject.FindGameObjectWithTag("Sound"));
        SceneManager.LoadScene("gameEnd");
        Destroy(GameObject.FindObjectOfType<PlaceAtLocation>().gameObject);
    }

    public void ClickBack()
    {
        SceneManager.LoadScene("cat_model");
    }
}
