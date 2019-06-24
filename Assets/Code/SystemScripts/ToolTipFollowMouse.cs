using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.SystemScripts
{
    public class ToolTipFollowMouse : MonoBehaviour
    {
        public Canvas mainUICanvas;
        private Vector2 bottomLeft;
        private Vector2 topRight;
        private Rect cameraRect;

        void Start()
        {
            RectTransform canvasRect = (RectTransform)mainUICanvas.transform;
            bottomLeft = new Vector2(0, 0);
            topRight = new Vector2(canvasRect.rect.width,canvasRect.rect.height);

            cameraRect = new Rect(
              bottomLeft.x,
              bottomLeft.y,
              topRight.x,
              topRight.y);
        }

        void LateUpdate()
        {           
            transform.position = Input.mousePosition;
            RectTransform toolTipRect = (RectTransform)transform;
            if ((transform.position.y + toolTipRect.rect.height > cameraRect.max.y) || (transform.position.x + toolTipRect.rect.width > cameraRect.max.x))
            {
                float oldZ = transform.position.z;                
                transform.position = new Vector3(
                    Mathf.Clamp(transform.position.x, cameraRect.xMin, cameraRect.xMax - toolTipRect.rect.width), 
                    Mathf.Clamp(transform.position.y, cameraRect.yMin, cameraRect.yMax-toolTipRect.rect.height),
                    oldZ);
            }

        }
    }
    
}

