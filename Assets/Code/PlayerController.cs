using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Assets.Code
{
    class PlayerController : MonoBehaviour 
    {
        public C_Hero hero;

        private void Start()
        {
            hero = new C_Hero();
        }



    }
}
