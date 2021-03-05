using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateAround : MonoBehaviour
{
    [Header("Stationary Object To Rotate Around")]
    public GameObject BaseObject;//to get the position in worldspace to which this gameObject will rotate around.

    [Header("The axis by which it will rotate around")]
    public Vector3 axis;//by which axis it will rotate. x,y or z.

    [Header("Angle covered per update")]
    public float angle; //or the speed of rotation.

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(BaseObject.transform.position, axis, angle);
    }
}
