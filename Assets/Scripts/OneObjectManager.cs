using Assets.Scripts;
using UnityEngine;
using UnityEngine.EventSystems;

public class OneObjectManager : MonoBehaviour
{
    public GameObject objectToSpawn;

    private GameObject _spawnedObject;
    private PlacementIndicator _placementIndicator;

    void Start()
    {
        _placementIndicator = FindObjectOfType<PlacementIndicator>();
    }

    void Update()
    {
        if (Input.touchCount > 0 && Input.touches[0].phase == TouchPhase.Began)
        {
            if (!EventSystem.current.IsPointerOverGameObject(Input.GetTouch(0).fingerId))
            {
                if (_spawnedObject == null)
                {
                    _spawnedObject = Instantiate(objectToSpawn,
                        _placementIndicator.transform.position, _placementIndicator.transform.rotation);
                    _spawnedObject.name = "Earth_Object";
                }
                else
                {
                    _spawnedObject.transform.position = _placementIndicator.transform.position;
                    _spawnedObject.transform.rotation = _placementIndicator.transform.rotation;
                }
            }

        }
    }
}
