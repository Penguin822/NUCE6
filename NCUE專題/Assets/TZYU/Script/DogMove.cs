using UnityEngine;

public class DogMove : MonoBehaviour
{
    public GameObject dog;
    public GameObject bone;
    Animator dogAnimator;
    public GameObject ARCamera;

    public AudioClip soundEffect;
    private AudioSource audioSource;

    void Start()
    {
        dogAnimator = dog.GetComponent<Animator>();
        dogAnimator.SetBool("IsMoving", false);

        audioSource = GetComponent<AudioSource>();
        audioSource.enabled = false;
    }

    void Update()
    {
        var ARCamDistance = Vector3.Distance(dog.transform.position, ARCamera.transform.position);
        //Mathf.Abs(ARCamDistance) ==7.0f;
        if (Mathf.Abs(ARCamDistance) > 7.0f)
        {
            Debug.Log("notmove");
            dogAnimator.SetBool("IsMoving", false);
        }
        //else
        //{
            //Debug.Log("move");
            //dogAnimator.SetBool("IsMoving", true);

          //  var direction = bone.transform.position - dog.transform.position;
            //direction.y = 0;

           // dog.transform.Translate(direction.normalized * Time.deltaTime * 5.5f, Space.World);//move

            //var angle = Vector3.Angle(dog.transform.forward, direction);

            //var cross = Vector3.Cross(dog.transform.forward, direction);

            //var turn = cross.y >= 0 ? 1f : -1f;

           // dog.transform.Rotate(dog.transform.up, angle * Time.deltaTime * 5f * turn, Space.World);
        //}
    //var BoneDistance = Vector3.Distance(dog.transform.position, bone.transform.position);
    
        //if (Mathf.Abs(BoneDistance) < 10.0f)
        //{
          //  audioSource.enabled = true;
        //}
    }
}
