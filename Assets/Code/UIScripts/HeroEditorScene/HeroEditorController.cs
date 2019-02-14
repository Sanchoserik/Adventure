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
                case "attrChange": { setCommand(new CommandAttributeChange(C_PlayerController.mainHero, data)); break; }
                case "defValChange": { setCommand(new CommandDefenceValueChange(C_PlayerController.mainHero, data)); break; }
                case "levelChange": { setCommand(new CommandLevelChange(C_PlayerController.mainHero, data)); break; }
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
                case "StrengthVal": { text.text = C_PlayerController.mainHero.baseStrength.ToString(); break; }
                case "EnduranceVal": { text.text = C_PlayerController.mainHero.baseEndurance.ToString(); break; }
                case "KnowledgeVal": { text.text = C_PlayerController.mainHero.baseKnowledge.ToString(); break; }
                case "CharismaVal": { text.text = C_PlayerController.mainHero.baseCharisma.ToString(); break; }

                case "PhysicalDefVal": { text.text = C_PlayerController.mainHero.physDef.strValue; break; }
                case "FireDefVal": { text.text = C_PlayerController.mainHero.fireDef.strValue; break; }
                case "AirDefVal": { text.text = C_PlayerController.mainHero.airDef.strValue; break; }
                case "LightningDefVal": { text.text = C_PlayerController.mainHero.lightningDef.strValue; break; }
                case "EarthDefVal": { text.text = C_PlayerController.mainHero.earthDef.strValue; break; }
                case "WaterDefVal": { text.text = C_PlayerController.mainHero.waterDef.strValue; break; }
                case "LifeDefVal": { text.text = C_PlayerController.mainHero.lifeDef.strValue; break; }
                case "DeathDefVal": { text.text = C_PlayerController.mainHero.deathDef.strValue; break; }
                case "LightDefVal": { text.text = C_PlayerController.mainHero.lightDef.strValue; break; }
                case "DarknessDefVal": { text.text = C_PlayerController.mainHero.darknessDef.strValue; break; }

                case "HeroHPVal": { text.text = C_PlayerController.mainHero.baseMaxHP.ToString(); break; }
                case "HeroEnergyVal": { text.text = C_PlayerController.mainHero.baseMaxENE.ToString(); break; }
                case "HeroActionPointsVal": { text.text = C_PlayerController.mainHero.baseAP.ToString(); break; }
                case "HeroLevelVal": { text.text = C_PlayerController.mainHero.level.ToString(); break; }
                case "HeroExpVal": { text.text = C_PlayerController.mainHero.currExp.ToString(); break; }
                case "HeroNextLevelEXPVal": { text.text = C_PlayerController.mainHero.nextLevelExp.ToString(); break; }
                case "HeroSkillPointsVal": { text.text = C_PlayerController.mainHero.skillPoints.ToString(); break; }
                case "AttributePointsVal": { text.text = C_PlayerController.mainHero.attributePoints.ToString(); break; }
            }
        }
    }
}
