using Assets.Code.SystemScripts.LocalisationScripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.MainInvertoryScene
{
    public class ToolTip : MonoBehaviour
    {
        public Text toolTipItemName;
        public Text toolTipItemDescription;

        private List<ItemsLocalisationData> itemsData = SystemScripts.LoadLocalisation.itemsLocalisationData;

        private void Start()
        {
          gameObject.SetActive(false);
        }

        public void generateItemTooltip(string itemName)
        {
            gameObject.SetActive(true);
        }

    }
}
