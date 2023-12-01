using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Security.AccessControl;
using System;
using UnityEngine.SceneManagement;
using UnityEngine.Animations;

public class MainCamera : MonoBehaviour
{
    private string path;
    public Camera ARCam;

    public void OnScreenShootClick()
    {
        if (DogFlagInScreen.inScreen == false && CatFlagInScreen.inScreen == false && BirdFlagInScreen.inScreen == false) //�S�Ө�X�l
        {
            ScreenShoot(ARCam);
        }
        else //�i�J�C���A�]�T�ؤ��P�C�⪺�X�l�A�����T���d���C��
        {
            if (DogFlagInScreen.inScreen == true)
            {
                SceneManager.LoadScene("Dog_Main");
            }
            if (CatFlagInScreen.inScreen == true)
            {
                SceneManager.LoadScene("cat_game_intro");
            }
            if (BirdFlagInScreen.inScreen == true)
            {
                SceneManager.LoadScene("B_game");
            }
        }
    }

    //����Ϥ��O�s���|
    public string ScreenshotPath()
    {
        string filePath = "";
        if(Application.platform == RuntimePlatform.Android)
        {
            filePath = "/sdcard/DCIM/StepbyStep/";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
        }
        else
        {
            filePath = Application.dataPath + "/StepbyStep/";

            if (!Directory.Exists(filePath))
            {
                Directory.CreateDirectory(filePath);
            }
        }

        return filePath;
    }

    //�I�ϫO�s�����s�ۥU
    Texture2D ScreenShoot(Camera camera)
    {
        RenderTexture rt = new RenderTexture(Screen.width, Screen.height, 0);
        camera.targetTexture = rt;
        camera.Render();

        // �E��rt�A�ñq��Ū������
        RenderTexture.active = rt;
        Texture2D tex = new Texture2D(Screen.width, Screen.height, TextureFormat.RGB24, false);
        tex.ReadPixels(new Rect(0, 0, Screen.width, Screen.height), 0, 0, true);
        tex.Apply();       

        camera.targetTexture = null;
        RenderTexture.active = null;
        Destroy(rt);
        byte[] byt = tex.EncodeToPNG();

        //�Ϥ��W�١A�@��H����R�W
        DateTime currentTime = DateTime.Now;
        string fileName = "Custom" + currentTime.Year + currentTime.Month + currentTime.Day + "_" + currentTime.Hour + currentTime.Minute + currentTime.Second + ".png";
        path = ScreenshotPath() + fileName;
        File.WriteAllBytes(path, byt);
        string[] paths = { path };

        //�w�����x�~�եΦw�������ʨ�s�ۥU
        if (Application.platform == RuntimePlatform.Android)
        {
            ScanFile(paths);
        }
        return tex;
    }

    //��s�Ϥ��A��ܨ�ۥU��
    void ScanFile(string[] path)
    {
        using (AndroidJavaClass PlayerActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer"))
        {
            AndroidJavaObject playerActivity = PlayerActivity.GetStatic<AndroidJavaObject>("currentActivity");
            using (AndroidJavaObject Conn = new AndroidJavaObject("android.media.MediaScannerConnection", PlayerActivity, null))
            {
                Conn.CallStatic("scanFile", playerActivity, path, null, null);
            }
        }
    }
}
