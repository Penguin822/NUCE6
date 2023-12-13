using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlagInScreen : MonoBehaviour
{
    public bool inScreen;
    public int FlagID;

    private void OnBecameVisible()
    {
        inScreen = true;
    }
    private void OnBecameInvisible()
    {
        inScreen = false;
    }
}
