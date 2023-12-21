using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneTrigger : MonoBehaviour
{
    public Animator run;
    public Vector3 rotationSpeed = new Vector3(0, 45, 0); // 旋轉的速度

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player")) 
        {
            run.SetBool("IsMoving", false);
        }
    }
    private void Update()
    {
        transform.rotation *= Quaternion.Euler(rotationSpeed * Time.deltaTime);
    }
}
