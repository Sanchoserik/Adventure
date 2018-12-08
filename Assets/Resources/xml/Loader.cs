using UnityEngine;
using System.Collections;
using System.Collections.Generic; //Needed for Lists
using System.Xml; //Needed for XML functionality
using System.Xml.Serialization; //Needed for XML Functionality
using System.IO;
using System.Xml.Linq; //Needed for XDocument

public class Loader : MonoBehaviour
{
    XDocument xmlDoc; //create Xdocument. Will be used later to read XML file 
    List <skillData> data = new List <skillData>();   
    //Initialize List of XMLData objects.
    bool finishedLoading = false;

    void Start()
    {
        DontDestroyOnLoad(gameObject); //Allows Loader to carry over into new scene LoadXML (); 
                                       //Loads XML File. Code below.
                                       // StartCoroutine("AssignData");         
                                       //Starts assigning XML data to data List. Code below
        LoadXML();
        int xx = 20;
    }
    void Update()
    {
        //just why?
        //if (finishedLoading)
        //{
        //    //UnityEngine.SceneManagement.SceneManager.LoadScene("Options");
        //    //Only happens if coroutine is finished finishedLoading = false;
        //}
    }

    void LoadXML()
    {
        IEnumerable<XElement> items; // <skill> tag
        //Create an Ienumerable list. Will be used to store XML Items.
        IEnumerable<XElement> skilllevels; // <l> tag
        IEnumerable<XElement> leveldata; // <v tag>
        //Assigning Xdocument xmlDoc. Loads the xml file from the file path listed. 
        xmlDoc = XDocument.Load("Assets/Resources/xml/skills.xml");
        //This basically breaks down the XML Document into XML Elements. Used later.

        items = xmlDoc.Descendants("skills").Elements();
        skilllevels = xmlDoc.Descendants("skill").Elements();
        //leveldata = xmlDoc.Descendants("l").Elements();
        //find skill data
        foreach (XElement item in items)
        {               
            //get <skill> attributes
                short _levels = short.Parse(item.Attribute("levels").Value);
                string _name = item.Attribute("name").Value.Trim();
                string _scname = item.Attribute("scname").Value.Trim();

            Dictionary<int, string> lDataEne = new Dictionary<int, string>();
            Dictionary<int, string> lDataAP = new Dictionary<int, string>();
            Dictionary<string, string> vValues = new Dictionary<string, string>();

            bool moveforward = true;
            bool firstcheck = false;
            int levelIter = 1;
            foreach (XElement el in item.Elements("l"))
            {
               firstcheck = true;
              
               lDataEne.Add(levelIter, el.Attribute("pEne").Value);
               lDataAP.Add(levelIter, el.Attribute("pAP").Value);
 
               foreach (XElement vTag in el.Nodes())
               {               
                 vValues.Add(vTag.Attribute("name").Value.Trim(), vTag.Element("v").Value.Trim());
               }              
               ++levelIter;
            }
            
            int x = 0;
            //item.

            data.Add(new skillData(_levels, _name, _scname));     
           // Debug.Log("name =" + _name + "  levels = "+ _levels + "  scname = " + _scname);          
        }       
    }
}
// This class is used to assign our XML Data to objects in a list so we can call on them later.
public class skillData {

    public short levels;
    public string name, scname;
    // Create a constructor that will accept multiple arguments that can be assigned to our variables. 
    public skillData(short _levels, string _name, string _scname)
    {
         levels = _levels;
         name = _name;
         scname = _scname;     
    }

    public void skillLevels()
    {

    }


}