using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightControler : MonoBehaviour
{
    [SerializeField] private LayerMask _layerTile;
    [SerializeField] private float _distance = 50f;
    
    private Tile _tile;
    
    private Camera _camera;
    private void Awake()
    {
        _camera = Camera.main;
    }
    
    private void Update()
    {
        var ray = _camera.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray,out var info,_distance))
        {
            var tile = info.collider.GetComponent<Tile>();
            if (tile != null)
            {
                if (_tile != tile)
                {
                    if (_tile != null)
                    {
                        _tile.Highlight(false); 
                    }
                    _tile = tile;
                    _tile.Highlight(true);
                }
            }
        }
    }
}
