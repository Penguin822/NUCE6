using ARLocation.MapboxRoutes;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class place_dog : MonoBehaviour
{
   
    public GameObject cat;

    public ARSessionOrigin sessionOrigin;
    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;

    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        cat.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        if (raycastManager.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.2f, 0f)), raycastHits, TrackableType.PlaneWithinPolygon))  //從畫面正中央偏下的位置射出射線，動物的生成位置較接近腳邊
        {
            cat.transform.position = raycastHits[0].pose.position;
            cat.SetActive(true);

            if (cat.activeInHierarchy)
            {
                Destroy(GetComponent<place_dog>());
            }
        }
    }
}
