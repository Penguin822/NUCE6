using System;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class cat_box : MonoBehaviour
{
    public GameObject cube;
    public GameObject cubeManager;
    public GameObject fish;
    public GameObject box;
    public List<GameObject> waypoints;
    private Animator animator;
    int index = 0;
    int round = 0;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("close", true);

        //canvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 fishDes = new Vector3(box.transform.position.x, (float)(box.transform.position.y + 0.8), box.transform.position.z); //原來的new Vector3(box.transform.position.x, (float)(box.transform.position.y + 0.8), box.transform.position.z); 新的測試版的new Vector3(box.transform.position.x, 0.2f, box.transform.position.z);
        fish.transform.position = Vector3.MoveTowards(fish.transform.position, fishDes, 1f * Time.deltaTime);

        Vector3 destination = waypoints[index].transform.position;
        

        float distance = Vector3.Distance(transform.position, destination);

        if (round <= 3 && fish.transform.position.y == -2.4f) //原本是if (round <= 3 && fish.transform.position.y == -2.4f)；新的測試版的if (round <= 3 && fish.transform.position.y == 0.2f)
        {
            transform.position = Vector3.MoveTowards(transform.position, waypoints[index].transform.position, 2f * Time.deltaTime);

            if (distance <= 0.05)
            {
                if (cat_randomValue.random[round] < 0.5)
                {
                    if (index == 2)
                    {
                        index = 0;
                    }
                    else
                    {
                        index++;
                    }
                    round++;
                }
                else
                {
                    if (index == 0)
                    {
                        index = 2;
                    }
                    else
                    {
                        index--;
                    }
                    round++;
                }
            }
        }

        //Cube出現
        if (round == 4)
        {
             cube.SetActive(true);
             cubeManager.SetActive(true);           
        }
    }
}
