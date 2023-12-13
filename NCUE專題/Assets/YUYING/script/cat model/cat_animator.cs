using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cat_animator : MonoBehaviour
{
    private Animator animator;
    public Button btnSitDown;
    public Button btnStandUp;
    public Button btnEat; 
    public Button btnWashFace;
    int catExp;

    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        catExp = PlayerPrefs.GetInt("catExp");

        if (catExp <= 1000)
        {
            btnSitDown.interactable = true;
            btnStandUp.interactable = true;
            btnEat.interactable = false;
            btnWashFace.interactable = false;
        }
        if (catExp > 1000 && catExp <= 2000)
        {
            btnSitDown.interactable = true;
            btnStandUp.interactable = true;
            btnEat.interactable = true;
            btnWashFace.interactable = false;
        }
        if (catExp > 2000)
        {
            btnSitDown.interactable = true;
            btnStandUp.interactable = true;
            btnEat.interactable = true;
            btnWashFace.interactable = true;
        }
    }

    public void BtnSitDownPressed()
    {
        animator.ResetTrigger("eat");
        animator.ResetTrigger("washFace");
        animator.SetBool("sitDown", true);
        animator.SetTrigger("sitDown2");
    }
    public void BtnStandUpPressed()
    {
        animator.SetBool("sitDown", false);
        animator.ResetTrigger("eat");
        animator.ResetTrigger("washFace");
        animator.ResetTrigger("sitDown2");
    }
    public void BtnEatPressed()
    {
        animator.SetBool("sitDown", false);
        animator.ResetTrigger("washFace");
        animator.SetTrigger("eat");
        animator.ResetTrigger("sitDown2");
    }
    public void BtnWashFacePressed()
    {
        animator.SetBool("sitDown", false);
        animator.ResetTrigger("eat");
        animator.SetTrigger("washFace");
        animator.ResetTrigger("sitDown2");
    }
}
