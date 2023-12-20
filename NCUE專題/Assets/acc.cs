using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class acc : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float temp = Input.acceleration.x;
        //Debug.Log(temp);

        transform.Translate(temp, 0, 0);
    }
}
