using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class AutoPlaceItemForGame : MonoBehaviour
{
    public GameObject cat;
    public GameObject box;
    public ARSessionOrigin sessionOrigin;
    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;

    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        cat.SetActive(false);
        box.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (raycastManager.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.2f, 0f)), raycastHits, TrackableType.PlaneWithinPolygon))  //從畫面正中央偏下的位置射出射線，動物的生成位置較接近腳邊
        {
            cat.transform.position = raycastHits[0].pose.position;
            box.transform.position = new Vector3(box.transform.position.x, cat.transform.position.y, box.transform.position.z);
            box.SetActive(true);
            cat.SetActive(true);

            foreach (var planes in planeManager.trackables)
            {
                planes.gameObject.SetActive(false);
            }
            planeManager.enabled = false;

            if (cat.activeInHierarchy)
            {
                Destroy(GetComponent<AutoPlaceItemForGame>());
            }
        }
    }
}
