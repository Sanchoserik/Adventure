using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code.UIScripts.MainInvertoryScene
{
    class FollowMouse : MonoBehaviour
    {
        private void Update()
        {           
            transform.position = Input.mousePosition;
        }
    }
}
