using UnityEngine;
using System.Collections;
using System.Collections.Generic; //Needed for Lists
using System.Xml; //Needed for XML functionality
using System.Xml.Serialization; //Needed for XML Functionality
using System.IO;
using System.Xml.Linq; //Needed for XDocument

// no namespace
public class Loader : MonoBehaviour
{
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

    void LoadXML() // param localisation!
    {
        IEnumerable<XElement> items; // <skill> tag        
        IEnumerable<XElement> skillLevels; // <l> tag
        IEnumerable<XElement> skillLoc; // localisation <skill> tag

        //Assigning Xdocument xmlDoc. Loads the xml file from the file path listed. 
        XDocument skillsXDoc = XDocument.Load("Assets/Resources/xml/skills.xml");
       
              // UA LOCALISATION by deffault
        XDocument skillsLocXDoc = XDocument.Load("Assets/Resources/xml/skillsLocUA.xml");
        
        items = skillsXDoc.Descendants("skills").Elements();
        skillLevels = skillsXDoc.Descendants("skill").Elements();

        skillLoc = skillsLocXDoc.Descendants("skills").Elements(); // get localisation 
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
            // int is skill level
            List<Dictionary<string, string>> vValues = new List<Dictionary<string, string>>();         
       
            int levelIter = 1;
            foreach (XElement el in item.Elements("l"))
            {        
               // level AP&Ene cost values
               lDataEne.Add(levelIter, el.Attribute("pEne").Value);
               lDataAP.Add(levelIter, el.Attribute("pAP").Value);
                // special level values in "v" element
                if (el.Nodes() != null)
                { vValues.Add(new Dictionary<string, string>());
                    foreach (XElement vTag in el.Nodes())
                    {
                       vValues[vValues.Count-1].Add(vTag.Attribute("name").Value, vTag.Value);                     
                    }
                }
               ++levelIter;              
            }//end foreach
            //saving data 
            data.Add(new skillData(_levels, _name, _scname, lDataAP, lDataEne, vValues));                 
        }

        int iter = 0; // iter
        foreach (XElement item in skillLoc)
        {
            data[iter].locName = item.Attribute("locname").Value;
            data[iter].sDescr = item.Attribute("descr").Value;
            List<string> levelsDescr = new List<string>();
            foreach (XElement el in item.Elements("l"))
            {
                levelsDescr.Add(el.Value);
            }
            data[iter].locDescr = levelsDescr;
            ++iter;
        }

    }
}//end class loader
// This class is used to assign our XML Data to objects in a list so we can call on them later.
public class skillData {

    public short levels;
    public string name;
    public string scName;
    public Dictionary<int, string> lcAP;
    public Dictionary<int, string> lcEne;
    public List<Dictionary<string, string>> vValues;
    //localisation
    public string locName;
    public List<string> locDescr;
    public string sDescr; // skil description

    // Create a constructor that will accept multiple arguments that can be assigned to our variables. 
    public skillData(short _levels, string _name, string _scname, Dictionary<int, string> _lcAP, 
        Dictionary<int, string> _lcEne, List<Dictionary<string, string>> _vValues) 
     //   string _locName, List<string> _locDescr)
    {
        levels = _levels;
        name = _name;
        scName = _scname;
        lcAP = _lcAP;
        lcEne = _lcEne;
        vValues = _vValues;
     //   locName = _locName;
     //   locDescr = _locDescr;
    }
}