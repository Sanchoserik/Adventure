using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Code.UIScripts.CharacterMenuScene.SkillTree
{
    public class SkillBranchChange : MonoBehaviour
    {
        public GameObject tacticianBranch;
        public GameObject warriorBranch;
        public GameObject assassinBranch;
        public GameObject bruiserBranch;

        public void changeBranch(GameObject branch)
        {
            tacticianBranch.SetActive(false);
            warriorBranch.SetActive(false);
            assassinBranch.SetActive(false);
            bruiserBranch.SetActive(false);

            branch.SetActive(true);
        }

    }
}
