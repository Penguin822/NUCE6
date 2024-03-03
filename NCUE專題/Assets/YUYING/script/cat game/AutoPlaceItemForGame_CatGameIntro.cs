using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
public class AutoPlaceItemForGame_CatGameIntro : MonoBehaviour
{
    public GameObject cat;
    public GameObject box1;
    public GameObject box2;
    public GameObject box3;
    public GameObject waypoint0;
    public GameObject waypoint1;
    public GameObject waypoint2;
    public GameObject fish;

    public ARSessionOrigin sessionOrigin;
    public ARRaycastManager raycastManager;
    public ARPlaneManager planeManager;

    private List<ARRaycastHit> raycastHits = new List<ARRaycastHit>();

    // Start is called before the first frame update
    void Start()
    {
        cat.SetActive(false);
        box1.SetActive(false);
        box2.SetActive(false);
        box3.SetActive(false);
        waypoint0.SetActive(false);
        waypoint1.SetActive(false);
        waypoint2.SetActive(false);
        fish.SetActive(false);
    }
    // Update is called once per frame
    void Update()
    {
        if (raycastManager.Raycast(Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.4f, 0f)), raycastHits, TrackableType.PlaneWithinPolygon))  //從畫面正中央偏下的位置射出射線，動物的生成位置較接近腳邊
        {
            cat.transform.position = raycastHits[0].pose.position;
            box1.transform.position = new Vector3(cat.transform.position.x, cat.transform.position.y, cat.transform.position.z + 3.3f - 5.45f);
            box2.transform.position = new Vector3(cat.transform.position.x + 1f, cat.transform.position.y, cat.transform.position.z + 4.3f - 5.45f);
            box3.transform.position = new Vector3(cat.transform.position.x - 1f, cat.transform.position.y, cat.transform.position.z + 4.3f - 5.45f);
            waypoint0.transform.position = box1.transform.position;
            waypoint1.transform.position = box2.transform.position;
            waypoint2.transform.position = box3.transform.position;
            fish.transform.position = new Vector3(cat.transform.position.x, cat.transform.position.y + 2f, cat.transform.position.z - 2.15f);

            cat.SetActive(true);
            box1.SetActive(true);
            box2.SetActive(true);
            box3.SetActive(true);
            waypoint0.SetActive(true);
            waypoint1.SetActive(true);
            waypoint2.SetActive(true);
            fish.SetActive(true);

            //foreach (var planes in planeManager.trackables)
            //{
            //    planes.gameObject.SetActive(false);
            //}
            //planeManager.enabled = false;

            if (cat.activeInHierarchy)
            {
                Destroy(GetComponent<AutoPlaceItemForGame_CatGameIntro>());
            }
        }
    }
}
