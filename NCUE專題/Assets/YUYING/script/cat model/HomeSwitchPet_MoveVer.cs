using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class HomeSwitchPet_MoveVer : MonoBehaviour
{
    Vector2 startpos;
    Vector2 start, end;

    bool IsMouse = false;

    bool right = false;
    bool left = false;
    int index = 0;

    public List<GameObject> pets;

    //GameObject currentSelected = UnityEngine.EventSystems.EventSystem.current.currentSelectedGameObject;

    // Update is called once per frame
    void Update()
    {
        startpos.x = Input.mousePosition.x;
        startpos.y = Input.mousePosition.y;

        if (Input.GetMouseButtonDown(0))
        {
            start = startpos;
            IsMouse = false;
        }
        //if (Input.GetMouseButtonUp(0)) //�ԥX�h�t�~��public function�g�A�~���SwitchPetMask�̪�EventTrigger�����I���d��
        //{
        //    MouseUp();
        //}

        //�P�_�����٬O�k��
        if (IsMouse)
        {
            LeftOrRight();
        }

        //���k���ʵe
        if(right && index >= 0)
        {
            index--;
            if(index < 0)
            {
                index = 2; //�쬰0
            }
            pets[index].SetActive(true);
            right = false;
        }
        //�������ʵe
        if(left && index < 3)
        {
            index++;
            if(index > 2)
            {
                index = 0; //�쬰2
            }
            pets[index].SetActive(true);
            left = false;
        }
    }

    void LeftOrRight()
    {
        pets[0].SetActive(false);
        pets[1].SetActive(false);
        pets[2].SetActive(false);
        if (start.x - end.x < 0)
        {
            right = true;
        }
        if(start.x - end.x > 0 || start.x - end.x == 0) //�W�[��a�I��
        {
            left = true;
        }
        IsMouse = false;
    }

    public void MouseUp() //�bSwitchPetMask�̪�EventTrigger�ϥΡA�����I���d��
    {
        end = startpos;
        IsMouse = true;
    }
}
