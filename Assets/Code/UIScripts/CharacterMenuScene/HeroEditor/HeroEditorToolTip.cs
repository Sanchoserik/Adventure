using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.HeroEditor
{
    public class HeroEditorToolTip : MonoBehaviour
    {
        public Text helpInfo;

        private bool toolTipGenerated;

        private void Start()
        {
            toolTipGenerated = false;
            gameObject.SetActive(false);
           
        }

    }
}
