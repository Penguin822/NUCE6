using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using UnityEditor;

public class PetPlacementManagerForCamera : MonoBehaviour
{
    GameObject SpawnablePet;
    public GameObject dog;
    public GameObject cat;
    public GameObject bird;
    GameObject _object;

    public ARSessionOrigin sessionOrigin;
    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;

    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    private void Update()
    {
        if (Input.touchCount > 0)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                bool collision = raycastManager.Raycast(Input.GetTouch(0).position, raycastHits, TrackableType.PlaneWithinPolygon);

                if (collision && isButtonPressed() == false) //射線與地面撞擊 且 非點擊按鈕
                {
                    if (_object) //刪除先前生成的寵物
                    {
                         Destroy(_object);
                    }

                    _object = Instantiate(SpawnablePet); //生成新的寵物
                    var animator = _object.GetComponent<Animator>();
                    animator.Rebind(); //讓寵物動畫順利運作
                    _object.transform.position = raycastHits[0].pose.position;

                    if (SpawnablePet == bird) //鳥模型與貓狗的模型方向不同
                    {                      
                        _object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y, raycastHits[0].pose.rotation.z); // raycastHits[0].pose.rotation;
                    }
                    else
                    {
                        _object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y - 180, raycastHits[0].pose.rotation.z);
                    }                  
                }

                //foreach(var planes in planeManager.trackables)
                //{
                //    planes.gameObject.SetActive(false);
                //}

                //planeManager.enabled = false;
            }
        }
    }

    public bool isButtonPressed()
    {
        if(EventSystem.current.currentSelectedGameObject?.GetComponent<Button>() == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }

    public void SwitchPetDDog()
    {
        SpawnablePet = dog;
        raycastManager.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)), raycastHits, TrackableType.PlaneWithinPolygon);
        if (_object) //刪除先前生成的寵物
        {
            Destroy(_object);
        }

        _object = Instantiate(SpawnablePet); //生成新的寵物
        var animator = _object.GetComponent<Animator>();
        animator.Rebind(); //讓寵物動畫順利運作
        _object.transform.position = raycastHits[0].pose.position;
        _object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y - 180, raycastHits[0].pose.rotation.z);   
    }
    public void SwitchPetCat()
    {
        SpawnablePet = cat;
        raycastManager.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)), raycastHits, TrackableType.PlaneWithinPolygon);
        if (_object) //刪除先前生成的寵物
        {
            Destroy(_object);
        }

        _object = Instantiate(SpawnablePet); //生成新的寵物
        var animator = _object.GetComponent<Animator>();
        animator.Rebind(); //讓寵物動畫順利運作
        _object.transform.position = raycastHits[0].pose.position;
        _object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y - 180, raycastHits[0].pose.rotation.z);
    }
    public void SwitchPetBird()
    {
        SpawnablePet = bird;
        raycastManager.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)), raycastHits, TrackableType.PlaneWithinPolygon);
        if (_object) //刪除先前生成的寵物
        {
            Destroy(_object);
        }

        _object = Instantiate(SpawnablePet); //生成新的寵物
        var animator = _object.GetComponent<Animator>();
        animator.Rebind(); //讓寵物動畫順利運作
        _object.transform.position = raycastHits[0].pose.position;
        _object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y, raycastHits[0].pose.rotation.z);
    }

    public void DestroyPet()
    {
        if (_object) 
        {
            Destroy(_object);
        }
    }
}
