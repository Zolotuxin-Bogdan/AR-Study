using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    private GameObject _objectToRotate;

    public void RotateToRight()
    {
        if (_objectToRotate == null)
        {
            _objectToRotate = GameObject.Find("Earth_Object");
        }

        _objectToRotate.transform.Rotate(new Vector3(_objectToRotate.transform.rotation.x, _objectToRotate.transform.rotation.y - 5));
    }

    public void RotateToLeft()
    {
        if (_objectToRotate == null)
        {
            _objectToRotate = GameObject.Find("Earth_Object");
        }

        _objectToRotate.transform.Rotate(new Vector3(_objectToRotate.transform.rotation.x, _objectToRotate.transform.rotation.y + 5));
    }
}
