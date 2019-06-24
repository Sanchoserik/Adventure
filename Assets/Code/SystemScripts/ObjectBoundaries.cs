using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.SystemScripts
{
    public class ObjectBoundaries : MonoBehaviour
    {
        public Canvas mainUICanvas;
        private Vector2 bottomLeft;
        private Vector2 topRight;
        private Rect cameraRect;

        void Start()
        {
            RectTransform rtc = (RectTransform)mainUICanvas.transform;
            bottomLeft = new Vector2(0, 0);//rtc.rect.min;
            topRight = new Vector2(1366,768);

            cameraRect = new Rect(
              bottomLeft.x,
              bottomLeft.y,
              topRight.x - bottomLeft.x,
              topRight.y - bottomLeft.y);
        }

        void LateUpdate()
        {           
            transform.position = Input.mousePosition;
            RectTransform rt = (RectTransform)transform;
            if ((transform.position.y + rt.rect.height > cameraRect.max.y) || (transform.position.x + rt.rect.width > cameraRect.max.x))
            {
                float oldx = transform.position.x;
                float oldz = transform.position.z;                
                transform.position = new Vector3(Mathf.Clamp(transform.position.x, cameraRect.xMin, cameraRect.xMax - rt.rect.width), 
                    Mathf.Clamp(transform.position.y, cameraRect.yMin, cameraRect.yMax-rt.rect.height), oldz);
            }

        }
    }
    
}

