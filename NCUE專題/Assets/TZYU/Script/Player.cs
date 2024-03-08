using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using ARLocation;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    public GameObject buttonToActivate;
     public GameObject dog;
    public GameObject bone;
    Animator dogAnimator;
    public GameObject ARCamera;
    public AudioClip collisionSound;
    public AudioClip soundEffect;
    private AudioSource audioSource;

    static public bool coll = false;

    void Start()
    {
        dogAnimator = dog.GetComponent<Animator>();
        dogAnimator.SetBool("IsMoving", false);

        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = false;

        buttonToActivate.SetActive(false);
    }

    void Update()
    {
        var ARCamDistance = Vector3.Distance(dog.transform.position, ARCamera.transform.position);

        if (Mathf.Abs(ARCamDistance) > 10.0f)
        {
            //Debug.Log("notmove");
            dogAnimator.SetBool("IsMoving", false);
        }
          if (Mathf.Abs(ARCamDistance) <= 10.0f)
        {
            //Debug.Log("move");
            dogAnimator.SetBool("IsMoving", true);

            var direction = bone.transform.position - dog.transform.position;
            direction.y = 0;

            dog.transform.Translate(direction.normalized * Time.deltaTime * 5.5f, Space.World);//move

            var angle = Vector3.Angle(dog.transform.forward, direction);

            var cross = Vector3.Cross(dog.transform.forward, direction);

            var turn = cross.y >= 0 ? 1f : -1f;

            dog.transform.Rotate(dog.transform.up, angle * Time.deltaTime * 5f * turn, Space.World);
        }
        var BoneDistance = Vector3.Distance(dog.transform.position, bone.transform.position);
    

    }
    public void OnCollisionEnter(Collision collision)
    {
      
            coll = true;
            Debug.Log("Ä²µo¸I¼²½d³ò");
            buttonToActivate.SetActive(true);
            dogAnimator.SetBool("IsMoving", false);
            AudioSource.PlayClipAtPoint(collisionSound, transform.position);
        
    }
    public void SwitchScene()
    {
        SceneManager.LoadScene("Dog_Win");
    }
}
