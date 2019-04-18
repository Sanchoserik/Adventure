using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.MainInvertoryScene
{
    public class MainInvertorySceneController : MonoBehaviour
    {
        private int numberOfSlots = 5 ;
        public GameObject slotPrefab;
        public Transform mainHolder;

        private void Awake()
        {
            for (int i = 0; i < numberOfSlots; ++i)
            {
                GameObject instance = Instantiate(slotPrefab);
                instance.transform.SetParent(mainHolder);                
            }
        }

        private void Start()
        {
            

        }

        private void Update()
        {
           
            
        }
    }
}
