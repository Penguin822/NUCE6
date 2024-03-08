using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    
    public GameObject buttonToActivate;
    public AudioClip collisionSound;
    public Vector3 rotationSpeed = new Vector3(0, 45, 0); // 旋轉的速度

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            buttonToActivate.SetActive(true);
        }
    }
    private void Update()
    {
        transform.rotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime);
    }
}
