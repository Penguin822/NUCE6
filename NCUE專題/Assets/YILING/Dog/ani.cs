using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ani : MonoBehaviour
{
    public Animator animator;
    public Button sit;
    public Button shakehand;
    public Button roll;
    public Button dead; 
    int dogExp;

    // Start is called before the first frame update
    void Start()
    {
        dogExp = PlayerPrefs.GetInt("dogExp");

        if (dogExp <= 1000)
        {
            sit.interactable = true;
            shakehand.interactable = true;
            roll.interactable = false;
            dead.interactable = false;
        }
        if (dogExp > 1000 && dogExp <= 2000)
        {
            sit.interactable = true;
            shakehand.interactable = true;
            roll.interactable = true;
            dead.interactable = false;
        }
        if (dogExp > 2000)
        {
            sit.interactable = true;
            shakehand.interactable = true;
            roll.interactable = true;
            dead.interactable = true;
        }
    }

    public void deadAnimation()
    {
        animator.SetBool("dead", true);
        animator.ResetTrigger("roll");
        animator.ResetTrigger("shake");
        animator.ResetTrigger("sit");
    }
    public void rollAnimation()
    {
        animator.SetBool("roll", true);
        animator.ResetTrigger("dead");
        animator.ResetTrigger("shake");
        animator.ResetTrigger("sit");
    }
    public void shakehandAnimation()
    {
       animator.SetBool("shake", true);
       animator.ResetTrigger("roll");
       animator.ResetTrigger("dead");
       animator.ResetTrigger("sit");
    }
    public void sitAnimation()
    {
        animator.SetBool("sit", true);
        animator.ResetTrigger("roll");
        animator.ResetTrigger("shake");
        animator.ResetTrigger("dead");
    }
}
