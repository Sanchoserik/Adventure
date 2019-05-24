using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using Assets.PlayerController;

namespace Assets.Code.UIScripts.HeroEditorScene
{
    class HeroEditorController : MonoBehaviour
    {
        private ICommand inputCommand;
        private bool dataUpdated = false;
        public GameObject UIContainer;
     
        void Start()
        {
            getVisualValues();
            dataUpdated = true;
        }

        private void Update()
        {
            if (!dataUpdated)
            {
                getVisualValues();
                dataUpdated = true;
            }
        }
      
        public void buttonInput(PlusMinusButtonInputData commandData)
        {
            switchCommandType(commandData);
            inputCommand.execute();
        }

        public void buttonOpenSaveHeroDialog()
        {          
            try
            {
                var path = SFB.StandaloneFileBrowser.SaveFilePanel("SaveHero", "", "hero_save", "xml");
                Hero_Serialization.serializeHero(path.ToString());
            }
            catch
            {
                Debug.Log("Operation error");
            }
           
        }

        public void buttonOpenLoadHeroDialog()
        {
            var path = SFB.StandaloneFileBrowser.OpenFilePanel("LoadHero", "", "xml",false);
            try
            {
                Hero_Serialization.deserializeHero(path[0].ToString());
            }
            catch
            {
                Debug.Log("Save file not selected");
            }
            getVisualValues();
            dataUpdated = true;
        }

        private void switchCommandType(PlusMinusButtonInputData data )
        {
            switch (data.commandName)
            {
                case "attrChange": { setCommand(new CommandAttributeChange(HeroController.mainHero, data)); break; }
                case "defValChange": { setCommand(new CommandDefenceValueChange(HeroController.mainHero, data)); break; }
                case "levelChange": { setCommand(new CommandLevelChange(HeroController.mainHero, data)); break; }
            }
            dataUpdated = false;
        }

        private void setCommand(ICommand command)
        {
            inputCommand = command;
        }

        private void getVisualValues()
        {          
            foreach (Transform value in UIContainer.transform)
            {
                if (value.name.Contains("Val"))
                { updateVisualValues(value); }
            }
        }

        private void updateVisualValues(Transform textValue)
        {
            Text text = textValue.GetComponent<Text>();

            switch (textValue.name)
            {
                case "StrengthVal": { text.text = HeroController.mainHero.baseStrength.ToString(); break; }
                case "EnduranceVal": { text.text = HeroController.mainHero.baseEndurance.ToString(); break; }
                case "KnowledgeVal": { text.text = HeroController.mainHero.baseKnowledge.ToString(); break; }
                case "CharismaVal": { text.text = HeroController.mainHero.baseCharisma.ToString(); break; }

                case "PhysicalDefVal": { text.text = HeroController.mainHero.physDef.strValue; break; }
                case "FireDefVal": { text.text = HeroController.mainHero.fireDef.strValue; break; }
                case "AirDefVal": { text.text = HeroController.mainHero.airDef.strValue; break; }
                case "LightningDefVal": { text.text = HeroController.mainHero.lightningDef.strValue; break; }
                case "EarthDefVal": { text.text = HeroController.mainHero.earthDef.strValue; break; }
                case "WaterDefVal": { text.text = HeroController.mainHero.waterDef.strValue; break; }
                case "LifeDefVal": { text.text = HeroController.mainHero.lifeDef.strValue; break; }
                case "DeathDefVal": { text.text = HeroController.mainHero.deathDef.strValue; break; }
                case "LightDefVal": { text.text = HeroController.mainHero.lightDef.strValue; break; }
                case "DarknessDefVal": { text.text = HeroController.mainHero.darknessDef.strValue; break; }

                case "HeroHPVal": { text.text = HeroController.mainHero.baseMaxHP.ToString(); break; }
                case "HeroEnergyVal": { text.text = HeroController.mainHero.baseMaxENE.ToString(); break; }
                case "HeroActionPointsVal": { text.text = HeroController.mainHero.baseAP.ToString(); break; }
                case "HeroLevelVal": { text.text = HeroController.mainHero.level.ToString(); break; }
                case "HeroExpVal": { text.text = HeroController.mainHero.currExp.ToString(); break; }
                case "HeroNextLevelEXPVal": { text.text = HeroController.mainHero.nextLevelExp.ToString(); break; }
                case "HeroSkillPointsVal": { text.text = HeroController.mainHero.freeSkillPoints.ToString(); break; }
                case "AttributePointsVal": { text.text = HeroController.mainHero.freeAttributePoints.ToString(); break; }
            }
        }
    }
}
