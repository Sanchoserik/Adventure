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
        public GameObject canvas;
        public PlayerController controller;
        private InterfaceCommand inputCommand;
        private bool dataUpdated = false;

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
                case "attrChange": { setCommand(new CommandAttributeChange(controller.hero, data)); break; }
                case "defValChange": { setCommand(new CommandDefenceValueChange(controller.hero, data)); break; }
                case "levelChange": { setCommand(new CommandLevelChange(controller.hero, data)); break; }
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
                case "StrengthVal": { text.text = controller.hero.baseStrength.ToString(); break; }
                case "EnduranceVal": { text.text = controller.hero.baseEndurance.ToString(); break; }
                case "KnowledgeVal": { text.text = controller.hero.baseKnowledge.ToString(); break; }
                case "CharismaVal": { text.text = controller.hero.baseCharisma.ToString(); break; }

                case "PhysicalDefVal": { text.text = controller.hero.physDef.strValue; break; }
                case "FireDefVal": { text.text = controller.hero.fireDef.strValue; break; }
                case "AirDefVal": { text.text = controller.hero.airDef.strValue; break; }
                case "LightningDefVal": { text.text = controller.hero.lightningDef.strValue; break; }
                case "EarthDefVal": { text.text = controller.hero.earthDef.strValue; break; }
                case "WaterDefVal": { text.text = controller.hero.waterDef.strValue; break; }
                case "LifeDefVal": { text.text = controller.hero.lifeDef.strValue; break; }
                case "DeathDefVal": { text.text = controller.hero.deathDef.strValue; break; }
                case "LightDefVal": { text.text = controller.hero.lightDef.strValue; break; }
                case "DarknessDefVal": { text.text = controller.hero.darknessDef.strValue; break; }

                case "HeroHPVal": { text.text = controller.hero.baseMaxHP.ToString(); break; }
                case "HeroEnergyVal": { text.text = controller.hero.baseMaxENE.ToString(); break; }
                case "HeroActionPointsVal": { text.text = controller.hero.baseAP.ToString(); break; }
                case "HeroLevelVal": { text.text = controller.hero.level.ToString(); break; }
                case "HeroExpVal": { text.text = controller.hero.currExp.ToString(); break; }
                case "HeroNextLevelEXPVal": { text.text = controller.hero.nextLevelExp.ToString(); break; }
                case "HeroSkillPointsVal": { text.text = controller.hero.skillPoints.ToString(); break; }
                case "AttributePointsVal": { text.text = controller.hero.attributePoints.ToString(); break; }
            }
        }
    }
}
