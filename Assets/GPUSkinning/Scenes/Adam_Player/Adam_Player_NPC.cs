using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Adam_Player_NPC : MonoBehaviour 
{
	private GPUSkinningPlayer player;

	private float actionTime = 0;

	private float time = 0;
	int t = 0;
	
	private void Start () 
	{
		player = this.GetComponent<GPUSkinningPlayerMono>().Player;
		player.Play("Idle");
	}
	public void walk()
    {
		
		t = 1;
		
	
	}
	public void idle()
    {
		t = 0;
		
		
	}
	private void Update () 
	{
		time += Time.deltaTime;
		if(time > actionTime)
		{
			time = 0;
		
			if (t == 1)
			{
				
				player = this.GetComponent<GPUSkinningPlayerMono>().Player;
				player.CrossFade("walk", 0.2f);

			}
			else if(t == 0)
			{
				
				player = this.GetComponent<GPUSkinningPlayerMono>().Player;
				player.CrossFade("Idle", 0.2f);
			}
			
		}

		
	}
}
