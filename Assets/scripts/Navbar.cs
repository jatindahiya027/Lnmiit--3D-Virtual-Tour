using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navbar : MonoBehaviour
{


	public GameObject hidebutton;
	
	[SerializeField]
	private GameObject Navbar_obj;
	[SerializeField]
	private GameObject setting;
	[SerializeField]
	private GameObject teleport_button;
	[SerializeField]
	GameObject control_image;
	[SerializeField]
	GameObject map_;
	[SerializeField]
	GameObject screenshot_;
	[SerializeField]
	GameObject camera;
	[SerializeField]
	GameObject player;
	

	private void Start()
    {
		Navbar_obj.SetActive(false);
		Cursor.visible = false;
		Cursor.lockState = CursorLockMode.Locked;
	}
	private void Update()
    {
		//Debug.Log(Time.timeScale);
		if (Input.GetKeyDown(KeyCode.Escape) && !Navbar_obj.activeInHierarchy )
		{
			Navbar_obj.SetActive(true);
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			Time.timeScale = .0f;
		}
        else if (Input.GetKeyDown(KeyCode.Escape) && Navbar_obj.activeInHierarchy  )
        {
			
			hidebutton.SetActive(false);
			Navbar_obj.SetActive(false);
			Time.timeScale = 1f;
			
			hide_all();
			Cursor.visible = false;
			Cursor.lockState = CursorLockMode.Locked;
		}
	}
	public void Teleport()
	{
		hide_all();
		
		hidebutton.SetActive(true);
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.None;
		//camera_stay.SetActive(false);
		
	}
	public void quit()
	{
		Application.Quit();
	}

	public void controlimage()
	{
		hide_all();
		control_image.SetActive(true);
		
	}
	public void settings()
    {
		hide_all();
		setting.SetActive(true);
		
    }
	public void screenshot()
    {
		hide_all();
		screenshot_.SetActive(true);

    }
	public void map()
    {
		hide_all();
		camera.SetActive(true);
		map_.SetActive(true);
    }
    public void Player()
    {
		hide_all();
		player.SetActive(true);
    }

	private void hide_all()
    {
		setting.SetActive(false);
		control_image.SetActive(false);
		teleport_button.SetActive(false);
		map_.SetActive(false);
		screenshot_.SetActive(false);
		camera.SetActive(false);
		player.SetActive(false);

    }
}
