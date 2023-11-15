using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cursor : MonoBehaviour
{
    [SerializeField] private Collider _collider;
    [SerializeField] private Renderer _renderer;
    private Camera _camera;
    
    private void Awake()
    {
        _camera = Camera.main;
        
    }
    
    private void Update()
    {
        var ray = _camera.ScreenPointToRay(Input.mousePosition);
        
        
        if (_collider.Raycast(ray,out  var hitInfo,50f))
        {
            _renderer.material.color = Color.green;
        }
        else 
        {
            _renderer.material.color = Color.white;
        }
    }
}
