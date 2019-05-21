using Assets.Code.Items;
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

        private List<ItemsLocalisationData> itemsData;

        private void Start()
        {
            gameObject.SetActive(false);
            itemsData = SystemScripts.LoadLocalisation.itemsLocalisationData;
        }

        public void generateItemTooltip(A_Item item)
        {        
            ItemsLocalisationData itemLocalisation = itemsData.Find(x => x.itemName.Equals(item.GetType().Name));
            toolTipItemName.text = itemLocalisation.itemLocalisedName;
            toolTipItemDescription.text = itemLocalisation.itemLocalisedDescription;
            gameObject.SetActive(true);
        }

    }
}
