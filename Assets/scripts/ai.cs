using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class ai : MonoBehaviour
{

    public GameObject[] path_list;
    private NavMeshPath path;
    private int random = 0;
    [SerializeField]
    GameObject main_player;
    [SerializeField]
    int radius = 65;
    private NavMeshAgent agent;
    private Adam_Player_NPC npc;
  
    int i = 1;
    int walk_or_stay;
    void Start()
    {
        
        npc = this.GetComponent<Adam_Player_NPC>();
        
        path = new NavMeshPath();
        random = Random.Range(0, path_list.Length);
        radius = Random.Range(65, 100);
        agent = GetComponent<NavMeshAgent>();
        walk_or_stay = Random.Range(0, 2);
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(walk_or_stay);
         if (i == 0)
         {
             if (Vector3.Distance(this.transform.position, main_player.transform.position) > radius)
             {
               
                npc.idle();
                agent.ResetPath();
                 i = 1;
                 walk_or_stay = Random.Range(0,2);

             }
         }
    

    }
   
    int number(int rand)
    {
        while (true)
             {
            random = Random.Range(0, path_list.Length);
            if (random != rand)
             {
               break;
             }
             }
        return random;
    }

    private void OnTriggerStay(Collider other)
    {
        
        if (other.tag == "Player")
        {
           
            if (walk_or_stay == 0)
            {


                
                npc.walk();
                NavMesh.CalculatePath(this.transform.position, path_list[random].transform.position, NavMesh.AllAreas, path);
              
                if (agent.remainingDistance <= 1 && !agent.pathPending)
                {
                    if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                    {
                        // Done
                        random = number(random);
                        agent.destination = path_list[random].transform.position;

                    }

                }
              
                
            }
            else if (walk_or_stay == 1)
            {
                npc.idle();
                agent.ResetPath();
            }
           
        }
        i = 0;
    }


}
