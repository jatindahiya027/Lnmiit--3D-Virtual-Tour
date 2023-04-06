using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class button : MonoBehaviour
{
    Button btn;
    search t;
    Text txt;
    private void Start()
    {
        Transform child = transform.GetChild(0);
        btn = this.GetComponent<Button>();
        txt = child.GetComponent<Text>();
        if (txt.text.Equals("Library"))
        {
            btn.onClick.AddListener(library);
        }
       else if (txt.text.Equals("Cp"))
        {
            btn.onClick.AddListener(cp);
        }
        else if (txt.text.Equals("Market"))
        {
            btn.onClick.AddListener(market);
        }
        else if (txt.text.Equals("Sports"))
        {
            btn.onClick.AddListener(sports);
        }
        else if (txt.text.Equals("Mechanical"))
        {
            btn.onClick.AddListener(mechanical);
        }
        else if (txt.text.Equals("MessB"))
        {
            btn.onClick.AddListener(messb);
        }
        else if (txt.text.Equals("BH1"))
        {
            btn.onClick.AddListener(bh1);
        }
        else if (txt.text.Equals("BH2"))
        {
            btn.onClick.AddListener(bh2);
        }
        else if (txt.text.Equals("BH3"))
        {
            btn.onClick.AddListener(bh3);
        }
        else if (txt.text.Equals("BH4"))
        {
            btn.onClick.AddListener(bh4);
        }
        else if (txt.text.Equals("GuestHouse"))
        {
            btn.onClick.AddListener(guesthouse);
        }
        else if (txt.text.Equals("LT2"))
        {
            btn.onClick.AddListener(lt2);
        }

        t = GameObject.FindObjectOfType(typeof(search)) as search;
    }

    void library()
    {
         t.library();
      
    }
    void cp()
    {
        t.cp();
       
    }

    void market()
    {
        t.market();

    }
    void sports()
    {
        t.sports();

    }
    void mechanical()
    {
        t.mechanical();

    }
    void messb()
    {
        t.messb();

    }

    void bh1()
    {
        t.bh1();

    }
    void bh2()
    {
        t.bh2();

    }
    void bh3()
    {
        t.bh3();

    }
    void bh4()
    {
        t.bh4();

    }

    void guesthouse()
    {
        t.guesthouse();

    }
    void lt2()
    {
        t.lt2();

    }


}
