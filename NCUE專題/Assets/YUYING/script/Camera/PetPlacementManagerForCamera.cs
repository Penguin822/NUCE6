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

    Quaternion newRotation;
    int currentHitIndex;

    private void Update()
    {
        // ����۾�������
        Quaternion cameraRotation = Camera.main.transform.rotation;
        // �O�d�۾�����������A�N�����Ψ��d���ҫ�
        Vector3 euler = cameraRotation.eulerAngles;
        euler.x = 0;
        euler.z = 0;
        newRotation = Quaternion.Euler(euler);


        if (Input.touchCount > 0)
        {
            if(Input.GetTouch(0).phase == TouchPhase.Began)
            {
                bool collision = raycastManager.Raycast(Input.GetTouch(0).position, raycastHits, TrackableType.PlaneWithinPolygon);

                if (collision && isButtonPressed() == false) //�g�u�P�a������ �B �D�I�����s
                {
                    if (_object) //�R�����e�ͦ����d��
                    {
                         Destroy(_object);
                    }

                    _object = Instantiate(SpawnablePet); //�ͦ��s���d��
                    var animator = _object.GetComponent<Animator>();
                    animator.Rebind(); //���d���ʵe���Q�B�@
                    _object.transform.position = raycastHits[0].pose.position;

                    currentHitIndex = -1;
                    for (int i = 0; i < raycastHits.Count; i++)
                    {
                        if (raycastHits[i].pose.position == _object.transform.position)
                        {
                            currentHitIndex = i;
                            break;
                        }
                    }

                    if (currentHitIndex != -1 && currentHitIndex < raycastHits.Count)
                    {
                        if (SpawnablePet == bird) //���ҫ��P�ߪ����ҫ���V���P
                        {
                            //_object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y, raycastHits[0].pose.rotation.z); // raycastHits[0].pose.rotation;
                            _object.transform.rotation = newRotation;
                        }
                        else
                        {
                            _object.transform.rotation = Quaternion.Euler(
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.x,
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.y - 180,
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.z
                            );
                        }
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
        if (_object) //�R�����e�ͦ����d��
        {
            Destroy(_object);
        }

        _object = Instantiate(SpawnablePet); //�ͦ��s���d��
        var animator = _object.GetComponent<Animator>();
        animator.Rebind(); //���d���ʵe���Q�B�@
        _object.transform.position = raycastHits[0].pose.position;
        _object.transform.rotation = Quaternion.Euler(
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.x,
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.y - 180,
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.z
                            );
        //_object.transform.LookAt(Camera.main.transform);
        //_object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y - 180, raycastHits[0].pose.rotation.z);
        //_object.transform.rotation = newRotation;
        //_object.transform.rotation = Quaternion.Euler(_object.transform.rotation.x, _object.transform.rotation.y - 105, _object.transform.rotation.z);
    }
    public void SwitchPetCat()
    {
        SpawnablePet = cat;
        raycastManager.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)), raycastHits, TrackableType.PlaneWithinPolygon);
        if (_object) //�R�����e�ͦ����d��
        {
            Destroy(_object);
        }

        _object = Instantiate(SpawnablePet); //�ͦ��s���d��
        var animator = _object.GetComponent<Animator>();
        animator.Rebind(); //���d���ʵe���Q�B�@
        _object.transform.position = raycastHits[0].pose.position;
        _object.transform.rotation = Quaternion.Euler(
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.x,
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.y - 180,
                            raycastHits[currentHitIndex].pose.rotation.eulerAngles.z
                            );
        //_object.transform.LookAt(Camera.main.transform);
        //_object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y - 180, raycastHits[0].pose.rotation.z);
        //_object.transform.rotation = newRotation;
        //_object.transform.rotation = Quaternion.Euler(_object.transform.rotation.x, _object.transform.rotation.y - 105, _object.transform.rotation.z);
    }
    public void SwitchPetBird()
    {
        SpawnablePet = bird;
        raycastManager.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f)), raycastHits, TrackableType.PlaneWithinPolygon);
        if (_object) //�R�����e�ͦ����d��
        {
            Destroy(_object);
        }

        _object = Instantiate(SpawnablePet); //�ͦ��s���d��
        var animator = _object.GetComponent<Animator>();
        animator.Rebind(); //���d���ʵe���Q�B�@
        _object.transform.position = raycastHits[0].pose.position;
        //_object.transform.LookAt(Camera.main.transform);
        //_object.transform.rotation = Quaternion.Euler(raycastHits[0].pose.rotation.x, raycastHits[0].pose.rotation.y, raycastHits[0].pose.rotation.z);
        //_object.transform.rotation = Quaternion.Euler(_object.transform.rotation.x, _object.transform.rotation.y - 90, _object.transform.rotation.z);
        _object.transform.rotation = newRotation;
    }

    public void DestroyPet()
    {
        if (_object) 
        {
            Destroy(_object);
        }
    }
}
