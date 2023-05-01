using System;
using UnityEngine;

public class HighlightController : MonoBehaviour
{
   private HighlightableObject _lastHighlightableObject;

   private void Update()
   {
      var currentHighLightedObject = GetSelectedHighlightableObject();
      var isNewObject = _lastHighlightableObject != currentHighLightedObject;
      if (!isNewObject) return;
      if (_lastHighlightableObject != null)
      {
         _lastHighlightableObject.Reset();
      }

      if (currentHighLightedObject!=null)
      {
         currentHighLightedObject.Highlight();
      }

      _lastHighlightableObject = currentHighLightedObject;
   }

   private HighlightableObject GetSelectedHighlightableObject()
   {
      var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
      if (!Physics.Raycast(ray, out var hitInfo)) return null;
      var currentHighLightedObject = hitInfo.collider.gameObject.GetComponent<HighlightableObject>();
      return currentHighLightedObject;
   }
   
}
