using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pathend : MonoBehaviour
{
    [SerializeField]
    search end;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            end.cancelnavigation();
        }
    }
}
