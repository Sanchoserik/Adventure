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
    IEnumerable<XElement> items; 
                      //Create an Ienumerable list. Will be used to store XML Items.
    List <XMLData> data = new List <XMLData>();
    //Initialize List of XMLData objects.
    //int iteration = 0, pageNum = 0;
    //string charText, dialogueText; // ....

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
        //Assigning Xdocument xmlDoc. Loads the xml file from the file path listed. 
        xmlDoc = XDocument.Load("Assets/Resources/xml/skills.xml");
        //This basically breaks down the XML Document into XML Elements. Used later.
        items = xmlDoc.Descendants("skills").Elements();
        //this is our coroutine that will actually read and assign the XML data to our List IEnumerator AssignData()

        /*foreach allows us to look at every Element of our XML file and do something with each one. 
         * Basically, this line is saying “for each element in the xml document, do something.
        */
        foreach (var item in items)
        {
            //START READING XML
            /*Determine if the <page number> attribute in the XML is equal to whatever our current iteration of the loop is. 
             * If it is, then we want to assign our variables to the value of the XML Element that we need.
            */
           // if (item.Parent.Attribute("name").Value is string)  //== iteration.ToString()) //??? why...
           // {
                //got data
                short _levels = short.Parse(item.Attribute("levels").Value);
                string _name = item.Attribute("name").Value.Trim();
                string _scname = item.Attribute("scname").Value.Trim();
                /*Create a new Index in the List, which will be a new XMLData object and pass the previously
                 * assigned variables as arguments so they get assigned to the new object’s variables.
                */
                data.Add(new XMLData(_levels, _name, _scname));
                /*To test and make sure the data has been applied to properly, print out the musicClip name from the 
                 * data list’s current index. This will let us know if the objects in the list have been created
                 * successfully and if their variables have been assigned the right values.
                */
                Debug.Log("name =" + _name + "  levels = "+ _levels + "  scname = " + _scname);
                //iteration++; //increment the iteration by 1
           // }
        }
        finishedLoading = true; //tell the program that we’ve finished loading data.
        //yield return null; //????

    }
}
// This class is used to assign our XML Data to objects in a list so we can call on them later.
public class XMLData {

    public short levels;
    public string name, scname;
    // Create a constructor that will accept multiple arguments that can be assigned to our variables. 
    public XMLData(short _levels, string _name, string _scname)

    {
         levels = _levels;
         name = _name;
         scname = _scname;
        //pageNum = page;
        //charText = character;
        //dialogueText = dialogue;
    }
}