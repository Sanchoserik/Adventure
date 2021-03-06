﻿using Assets.Code.Items;
using Assets.Code.SystemScripts.DataStructures;
using Assets.Code.SystemScripts.LocalisationScripts;
using Assets.Code.SystemScripts.LocalisationScripts.LocalisationDataStructures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.Invertory
{
    public class ItemToolTip : MonoBehaviour
    {
        public Text toolTipItemName;
        public Text toolTipItemDescription;
        private bool toolTipGenerated;

        private List<ItemsLocalisationData> itemsLocalisationData;
        private List<ItemsData> itemsData; 

        private void Start()
        {
            toolTipGenerated = false;
            gameObject.SetActive(false);
            itemsLocalisationData = LocalisationManager.itemsLocalisationData;
            itemsData = SystemScripts.ResourcesManager.itemsData;
        }

        public void generateItemTooltip(A_Item item)
        {
            if (!toolTipGenerated && item != null)
            {
                //tooltip for standart items
                ItemsLocalisationData itemLocalisation = itemsLocalisationData.Find(x => x.itemName.Equals(item.GetType().Name));
                ItemsData itemData = itemsData.Find(x => x.itemName.Equals(item.GetType().Name));

                toolTipItemName.text = itemLocalisation.itemLocalisedName;
                toolTipItemDescription.text = getLocalisedText(itemLocalisation, itemData); // itemLocalisation.itemLocalisedDescription;
                //tooltip for Talismans

                gameObject.SetActive(true);
                toolTipGenerated = true;
            }
        }

        private string getLocalisedText(ItemsLocalisationData localisation, ItemsData data)
        {
            string fullDescription = localisation.itemLocalisedDescription;
            foreach(KeyValuePair<string, string> pair in data.itemsParameters)
            {
                fullDescription = fullDescription.Replace("$" + pair.Key + "$", pair.Value);
            }

            return fullDescription;
        }

        public void setToolTipGeneratedValue(bool val)
        {
            toolTipGenerated = val;
        }

    }
}
