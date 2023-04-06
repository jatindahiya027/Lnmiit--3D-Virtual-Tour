using System.Collections;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnityEngine;
using UnityEngine.UI;

public class search : MonoBehaviour
{
    // Start is called before the first frame update
    public InputField mainInputField;
    public Text scroll_text;
    public Transform content;
    public Button[] namelist;
    public GameObject[] positions;
    public GameObject end;
    public GameObject canvas;
    public GameObject line;
    public GameObject cancelnav;
    [SerializeField]
    private GameObject Navbar_obj;
    [SerializeField]
   Text placeholder;
    string t = null;
    void Start()
    {
        line.SetActive(false);
        end.SetActive(false);
        cancelnav.SetActive(false);
    }

    public void inputfield_test()
    {
        line.SetActive(false);
        cancelnav.SetActive(false);
        canvas.SetActive(true);
        end.SetActive(false);
        foreach (Transform child in content)
        {
            GameObject.Destroy(child.gameObject);
        }
        string pattern = "^[a-zA-Z0-9 ]*(?i)"+ mainInputField.text+ "(?-i)([a-zA-Z0-9]*)";
       
        if(mainInputField.text!=string.Empty)
        testt(pattern);


    }
    public void testt(string pattern)
    {

        
        for (int i = 0; i < namelist.Length; i++)
        {           
            Match match = Regex.Match(namelist[i].name, pattern);         
            if (match.Success)
            {
                var text = Instantiate(namelist[i],new Vector3(0f, 0f, 0f), Quaternion.identity,content);
                
            }
        }
    }
    public void inputfield_test_finish()
    {
        //Debug.Log(content.transform.childCount);
        
        if (content.transform.childCount > 0)
        {
            Transform child = content.transform.GetChild(0).transform.GetChild(0);
            Text txt = child.GetComponent<Text>();
            t = txt.text;
            if (txt.text.Equals("Library"))
            {
                library();
               // placeholder.text = "Library";
                
            }
            else if (txt.text.Equals("Cp"))
            {
                cp();
              //  placeholder.text = txt.text;

            }
            else if (txt.text.Equals("Market"))
            {
               market();
               // placeholder.text = txt.text;
            }
            else if (txt.text.Equals("Sports"))
            {
                sports();
              //  placeholder.text = txt.text;
            }
            else if (txt.text.Equals("Mechanical"))
            {
                mechanical();
                //placeholder.text = txt.text;
            }
            else if (txt.text.Equals("MessB"))
            {
                messb();
               // placeholder.text = txt.text;
            }
            else if (txt.text.Equals("BH1"))
            {
                bh1();
               // placeholder.text = txt.text;
            }
            else if (txt.text.Equals("BH2"))
            {
                bh2();
               // placeholder.text = txt.text;
            }
            else if (txt.text.Equals("BH3"))
            {
                bh3();
               // placeholder.text = txt.text;
            }
            else if (txt.text.Equals("BH4"))
            {
                bh4();
               // placeholder.text = txt.text;
            }
            else if (txt.text.Equals("GuestHouse"))
            {
               guesthouse();
                //placeholder.text = txt.text;
            }
            else if (txt.text.Equals("LT2"))
            {
                lt2();
               // placeholder.text = txt.text;
            }
        }
       mainInputField.text=string.Empty;
        placeholder.text = t;
        //Time.timeScale = 1f;

    }
    public void library()
    {
        activate_line(0);
        
    }
    public void cp()
    {
        activate_line(1);
       
    }
    public void market()
    {
        activate_line(2);
       

    }
    public void sports()
    {
        activate_line(3);
        

    }
    public void mechanical()
    {
        activate_line(4);
        

    }
    public void messb()
    {
        activate_line(5);
       

    }
    public void bh1()
    {
        activate_line(6);
       
    }
    public void bh2()
    {
        activate_line(7);
        
    }
    public void bh3()
    {
        activate_line(8);
       
    }
    public void bh4()
    {
        activate_line(9);
       

    }
    public void guesthouse()
    {
        activate_line(10);
        
    }
    public void lt2()
    {
        activate_line(11);
        
    }
    public void activate_line(int i)
    {
        end.transform.position = positions[i].transform.position;
        mainInputField.text = string.Empty;
        placeholder.text = positions[i].gameObject.name;
       foreach (Transform child in content)
        {
            GameObject.Destroy(child.gameObject);
        }
        canvas.SetActive(false);
        line.SetActive(true);
        cancelnav.SetActive(true);
        end.SetActive(true);
       // Time.timeScale = 1f;
       // Navbar_obj.SetActive(false);
        //Cursor.visible = false;
       //Cursor.lockState = CursorLockMode.Locked;
    }



    public void cancelnavigation()
    {
        line.SetActive(false);
        cancelnav.SetActive(false);
        end.SetActive(false);
       // Time.timeScale = 1f;
        //Debug.Log(content.transform.childCount);
        //Debug.Log(scroll_text.text);
       // Navbar_obj.SetActive(false);
       // Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
        placeholder.text = "Search Path..";
       
    }

}
