using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class teleport : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject player;

    public GameObject[] positions;
    public GameObject hidebutton;
    public Dropdown quality;

    [SerializeField]
    private GameObject Navbar_obj;

    public void pos1()
    {
        teleport_to_location(0);

    }
    public void pos2()
    {
        teleport_to_location(1);

    }
    public void none()
    {
        player.SetActive(false);
        
       // camera_stay.SetActive(true);
        player.SetActive(true);
       // Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
       // hidebutton.SetActive(false);
       // Navbar_obj.SetActive(false);
       // Time.timeScale = 1f;

    }


    public void CP()
    {
        Debug.Log("clicked on cp");
        teleport_to_location(2);

    }
    public void Mechnical()
    {
        teleport_to_location(3);

    }
    public void messb()
    {
        teleport_to_location(4);

    }
    public void market()
    {
        teleport_to_location(5);

    }
    public void sports()
    {
        teleport_to_location(6);


    }
    public void bh1()
    {
        teleport_to_location(7);


    }
    public void bh2()
    {
        teleport_to_location(8);


    }
    public void bh3()
    {
        teleport_to_location(9);


    }
    public void bh4()
    {
        teleport_to_location(10);


    }
    public void guesthouse()
    {
        teleport_to_location(11);


    }
    public void Library()
    {
        teleport_to_location(12);


    }
    public void lt()
    {
        teleport_to_location(13);


    }

    public void dropdown()
    {
        
        QualitySettings.SetQualityLevel(quality.value, false);
       // camera_stay.SetActive(true);
        //Cursor.visible = false;
       // Cursor.lockState = CursorLockMode.Locked;
       // hidebutton.SetActive(false);
       // Navbar_obj.SetActive(false);
       // Time.timeScale = 1f;

    }

    public void teleport_to_location(int i)
    {
        player.SetActive(false);
        player.gameObject.transform.position = positions[i].gameObject.transform.position;

       

        //camera_stay.SetActive(true);
        player.SetActive(true);
        StartCoroutine(wait());
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        //hidebutton.SetActive(false);
        // Navbar_obj.SetActive(false);
    }

    IEnumerator wait()
    {
        Time.timeScale = 1f;
        yield return new WaitForSeconds(0.5f);
        Time.timeScale = 0.00005f;
    }


}
