using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraZoom : MonoBehaviour
{

    private Camera _mainCamera;

    private float _targetZoom;
    private float _scrollData;


    [SerializeField]
    private float _zoomFactor = 1f;
    [SerializeField]
    private float _zoomFloor = 2f;
    [SerializeField]
    private float _zoomCeiling = 8f;


    private void Awake()
    {
        _mainCamera = Camera.main;
        _targetZoom = _mainCamera.orthographicSize;
    }


    public void OnZoom(InputAction.CallbackContext ctx)
    {
        _scrollData = ctx.ReadValue<float>();

        Debug.Log(_scrollData);

        _targetZoom -= _scrollData * _zoomFactor;

        _targetZoom = Mathf.Clamp(_targetZoom, _zoomFloor, _zoomCeiling);

        _mainCamera.orthographicSize = _targetZoom;
    }


}
