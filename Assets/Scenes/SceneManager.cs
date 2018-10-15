using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour {
 
    public void changeScene(string _name)
    {      
        UnityEngine.SceneManagement.SceneManager.LoadScene(_name);
    }
   
}
