using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class path : MonoBehaviour
{
    public LineRenderer lr;
    public Transform target;
    private NavMeshPath paath;
    public float tolerance = 1;
    // Start is called before the first frame update
    void Start()
    {
        paath = new NavMeshPath();
    lr.GetComponent<LineRenderer>();      
    }
    void Update()
    {
        NavMesh.CalculatePath(transform.position, target.position, NavMesh.AllAreas, paath);
        Vector3[] positions = new Vector3[paath.corners.Length];
       
        
        for (int i = 0; i < paath.corners.Length; i++) {
            
            if(i!=0 && paath.corners[i].y> paath.corners[i - 1].y)
            {
                //paath.corners[i].y = paath.corners[i].y + 0.2f;
            }
            paath.corners[i].y = paath.corners[i].y + 0.3f;
            positions[i] = paath.corners[i];
        }
        lr.positionCount = positions.Length;
        lr.SetPositions(positions);
        lr.Simplify(tolerance);

    }
}
