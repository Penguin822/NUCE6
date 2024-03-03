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
        //if (Input.GetMouseButtonUp(0)) //拉出去另外用public function寫，才能用SwitchPetMask裡的EventTrigger限制點擊範圍
        //{
        //    MouseUp();
        //}

        //判斷左移還是右移
        if (IsMouse)
        {
            LeftOrRight();
        }

        //往右移動畫
        if(right && index >= 0)
        {
            index--;
            if(index < 0)
            {
                index = 2; //原為0
            }
            pets[index].SetActive(true);
            right = false;
        }
        //往左移動畫
        if(left && index < 3)
        {
            index++;
            if(index > 2)
            {
                index = 0; //原為2
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
        if(start.x - end.x > 0 || start.x - end.x == 0) //增加原地點擊
        {
            left = true;
        }
        IsMouse = false;
    }

    public void MouseUp() //在SwitchPetMask裡的EventTrigger使用，限制點擊範圍
    {
        end = startpos;
        IsMouse = true;
    }
}
