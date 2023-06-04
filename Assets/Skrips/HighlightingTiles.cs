using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighlightingTiles : MonoBehaviour
{
    [SerializeField] private Collider _collider;
    [SerializeField] private Renderer _renderer;
 

    private void Update()
   {
       var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
       if (_collider.Raycast(ray, out var hitInfo, 50f))
       {
           _renderer.material.color = Color.gray;
           
       }
       
       else
       {
           _renderer.material.color = Color.white;
       }
   }
}
