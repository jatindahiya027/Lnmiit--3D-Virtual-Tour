using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookatcamera : MonoBehaviour
{

    private void FixedUpdate()
    {
        this.transform.LookAt(Camera.main.transform);
    }
}
