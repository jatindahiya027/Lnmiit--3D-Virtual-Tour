using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraChanger : MonoBehaviour
{
    [SerializeField]
    GameObject Cameramain;
    [SerializeField]
    GameObject CameraTop;

    private bool checker;
    // Start is called before the first frame update
    void Start()
    {
        //Screen.SetResolution(30, 30, true);
        CameraTop.SetActive(false);
        Cameramain.SetActive(true);
        checker = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.V))
        {
            if (checker == false)
            {
                CameraTop.SetActive(true);
                Cameramain.SetActive(false);
                RenderSettings.fog = false;
                checker = true;
            }
            else
            {
                CameraTop.SetActive(false);
                Cameramain.SetActive(true);
                checker = false;
                RenderSettings.fog = true;
            }
        }
    }
}
