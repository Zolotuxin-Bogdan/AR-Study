using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationManager : MonoBehaviour
{
    private GameObject _objectToRotate;

    private bool _isLeftRotation;
    private bool _isRightRotation;

    private float _speedRotation = 1f;
    void FixedUpdate()
    {
        if (_isLeftRotation)
        {
            LeftRotation();
        }
        else if (_isRightRotation)
        {
            RightRotation();
        }
    }
    private void RightRotation()
    {
        if (_objectToRotate == null)
        {
            _objectToRotate = GameObject.Find("Earth_Object");
        }

        _objectToRotate.transform.Rotate(new Vector3(0, - _speedRotation));
    }

    private void LeftRotation()
    {
        if (_objectToRotate == null)
        {
            _objectToRotate = GameObject.Find("Earth_Object");
        }

        _objectToRotate.transform.Rotate(new Vector3(0, + _speedRotation));
    }

    public void RotateToLeft()
    {
        _isLeftRotation = true;
    }

    private void RotateToRight()
    {
        _isRightRotation = true;
    }

    public void StopRotation()
    {
        _isLeftRotation = false;
        _isRightRotation = false;
    }
}
