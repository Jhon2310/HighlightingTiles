using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Tile : MonoBehaviour
{
   private Renderer _renderer;
  
   private void Start()
   {
      _renderer = GetComponent<Renderer>();
   }

   public void Highlight(bool isHigh)
   {
      _renderer.material.color = isHigh ? Color.green : Color.white;
   }
}
