using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace StarterAssets {
    public class Player_UI : MonoBehaviour
    {
        [SerializeField]
        ThirdPersonController player;
        [SerializeField]
        Slider walk;
        [SerializeField]
        Slider run;
       // [SerializeField]
        //Text walk_min;
       // [SerializeField]
        //Text walk_max;
        [SerializeField]
        Text walk_curr ;
        [SerializeField]
        Text run_min;
       // [SerializeField]
       // Text run_max;
        [SerializeField]
        Text run_curr;
      
        
        private void setter()
        {
            //int temp = (int)run.value;
            run.minValue = (int)player.MoveSpeed*4f;
            run.value = run.minValue;
            if (player.SprintSpeed < run.minValue)
            {
                player.SprintSpeed =(int)run.minValue;
                int i = (int)run.value;
                run_curr.text= i.ToString();
            }
           

        }
        public void Walk_speed()
        {
           // Debug.Log("walk called");
            player.MoveSpeed = (int)walk.value;
            setter();
            // walk_curr.text =(string)player.MoveSpeed;
            int i = (int)walk.value;
            walk_curr.text = i.ToString();
            i = (int)run.minValue;
            run_min.text = i.ToString();

        }
        public void Run_speed()
        {
           // Debug.Log("run_called");
            player.SprintSpeed = (int)run.value;
            int i = (int)run.value;
            run_curr.text = i.ToString();
            //temp = i;

        }
    }
   

}