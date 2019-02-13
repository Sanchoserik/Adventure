using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.HeroEditorScene
{
    class HeroEditorController : MonoBehaviour
    {
        private InterfaceCommand inputCommand;
        private bool dataUpdated = false;
        public GameObject canvas;

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

        private void switchCommandType(PlusMinusButtonInputData data )
        {
            switch (data.commandName)
            {
                case "attrChange": { setCommand(new CommandAttributeChange(PlayerController.mainHero, data)); break; }
                case "defValChange": { setCommand(new CommandDefenceValueChange(PlayerController.mainHero, data)); break; }
                case "levelChange": { setCommand(new CommandLevelChange(PlayerController.mainHero, data)); break; }
            }
            dataUpdated = false;
        }

        private void setCommand(InterfaceCommand command)
        {
            inputCommand = command;
        }

        private void getVisualValues()
        {          
            foreach (Transform value in canvas.transform)
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
                case "StrengthVal": { text.text = PlayerController.mainHero.baseStrength.ToString(); break; }
                case "EnduranceVal": { text.text = PlayerController.mainHero.baseEndurance.ToString(); break; }
                case "KnowledgeVal": { text.text = PlayerController.mainHero.baseKnowledge.ToString(); break; }
                case "CharismaVal": { text.text = PlayerController.mainHero.baseCharisma.ToString(); break; }

                case "PhysicalDefVal": { text.text = PlayerController.mainHero.physDef.strValue; break; }
                case "FireDefVal": { text.text = PlayerController.mainHero.fireDef.strValue; break; }
                case "AirDefVal": { text.text = PlayerController.mainHero.airDef.strValue; break; }
                case "LightningDefVal": { text.text = PlayerController.mainHero.lightningDef.strValue; break; }
                case "EarthDefVal": { text.text = PlayerController.mainHero.earthDef.strValue; break; }
                case "WaterDefVal": { text.text = PlayerController.mainHero.waterDef.strValue; break; }
                case "LifeDefVal": { text.text = PlayerController.mainHero.lifeDef.strValue; break; }
                case "DeathDefVal": { text.text = PlayerController.mainHero.deathDef.strValue; break; }
                case "LightDefVal": { text.text = PlayerController.mainHero.lightDef.strValue; break; }
                case "DarknessDefVal": { text.text = PlayerController.mainHero.darknessDef.strValue; break; }

                case "HeroHPVal": { text.text = PlayerController.mainHero.baseMaxHP.ToString(); break; }
                case "HeroEnergyVal": { text.text = PlayerController.mainHero.baseMaxENE.ToString(); break; }
                case "HeroActionPointsVal": { text.text = PlayerController.mainHero.baseAP.ToString(); break; }
                case "HeroLevelVal": { text.text = PlayerController.mainHero.level.ToString(); break; }
                case "HeroExpVal": { text.text = PlayerController.mainHero.currExp.ToString(); break; }
                case "HeroNextLevelEXPVal": { text.text = PlayerController.mainHero.nextLevelExp.ToString(); break; }
                case "HeroSkillPointsVal": { text.text = PlayerController.mainHero.skillPoints.ToString(); break; }
                case "AttributePointsVal": { text.text = PlayerController.mainHero.attributePoints.ToString(); break; }
            }
        }
    }
}
