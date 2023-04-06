using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering.PostProcessing;
public class Settings : MonoBehaviour
{ [SerializeField]
     Dropdown quality;
    [SerializeField]
    Dropdown Resolution;
    [SerializeField]
    GameObject settings;
    [SerializeField]
    private GameObject Navbar_obj;
    // [SerializeField]
    [SerializeField]
    Dropdown Antialiase;
    [SerializeField]
    PostProcessLayer antiliasee;
    [SerializeField]
    Dropdown mxaa_drop;
    [SerializeField]
    Toggle toggle;
    [SerializeField]
    GameObject _crowd;
    [SerializeField]
    GameObject fps;
    [SerializeField]
    GameObject minimap;
    [SerializeField]
    Toggle fps_toggle;
    [SerializeField]
    Toggle minimap_toggle;
    [SerializeField]
    GameObject Minimap_cam;
    [SerializeField]
    Toggle vsynctoggle;
    [SerializeField]
    Toggle ambient_acc;


    public PostProcessVolume _postprocessvolume;
    private AmbientOcclusion _ao;

    private void Start()
    {
        _postprocessvolume = GetComponent<PostProcessVolume>();
        _postprocessvolume.profile.TryGetSettings(out _ao);

        Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true);
        settings.SetActive(false);
        QualitySettings.SetQualityLevel(2, false);
        int qualityLevel = QualitySettings.GetQualityLevel();
        //Fetch the Toggle GameObject
       // toggle = GetComponent<Toggle>();
        //Add listener for when the state of the Toggle changes, to take action
       // toggle.onValueChanged.AddListener(delegate {
          //  ToggleValueChanged(toggle);
       // });
    }
   public void ToggleValueChanged()
    {
        //Debug.Log(toggle.isOn);
        if (toggle.isOn)
        {
            _crowd.SetActive(true);
        }
        else
        {
            _crowd.SetActive(false);
        }
    }
    public void VSync_Toggle()
    {
        //Debug.Log(toggle.isOn);
        if (vsynctoggle.isOn)
        {
            QualitySettings.vSyncCount = 1;
        }
        else
        {
            QualitySettings.vSyncCount = 0;
        }
    }
    public void FPS_TOGGLE()
    {
        //Debug.Log(toggle.isOn);
        if (fps_toggle.isOn)
        {
            fps.SetActive(true);
        }
        else
        {
            fps.SetActive(false);
        }
    }
    public void Minimap_toggle()
    {
        //Debug.Log(toggle.isOn);
        if (minimap_toggle.isOn)
        {
            minimap.SetActive(true);
            Minimap_cam.SetActive(true);
        }
        else
        {
            minimap.SetActive(false);
            Minimap_cam.SetActive(false);
        }
    }
    //public void settings_show()
    //  {
    //  //mainmenu.SetActive(false);
    //  settings.SetActive(true);
    // }

    //  public void setting_hide()
    // {
    //mainmenu.SetActive(true);
    // settings.SetActive(false);
    //Navbar_obj.SetActive(false);
    //Time.timeScale = 1f;
    // Cursor.visible = false;
    // /    // Cursor.lockState = CursorLockMode.Locked;
    //  }

    public void antiasing()
    {
        if (Antialiase.value == 0)
        {
            antiliasee.antialiasingMode = PostProcessLayer.Antialiasing.None;
        }
        else if(Antialiase.value == 1)
        {
            antiliasee.antialiasingMode = PostProcessLayer.Antialiasing.FastApproximateAntialiasing;
        }
        else if (Antialiase.value == 2)
        {
            antiliasee.antialiasingMode = PostProcessLayer.Antialiasing.SubpixelMorphologicalAntialiasing;
        }
        else if (Antialiase.value == 3)
        {
            antiliasee.antialiasingMode = PostProcessLayer.Antialiasing.TemporalAntialiasing;
        }
        //antiliasee.antialiasingMode = PostProcessLayer.Antialiasing.FastApproximateAntialiasing;
    }
    public void mxaa()
    {
        if (mxaa_drop.value == 0)
        {
            QualitySettings.antiAliasing = 0;
        }
        else if (mxaa_drop.value == 1)
        {
            QualitySettings.antiAliasing = 2;
        }
        else if (mxaa_drop.value == 2)
        {
            QualitySettings.antiAliasing = 4;
        }
        else if (mxaa_drop.value == 3)
        {
            QualitySettings.antiAliasing = 8;
        }
       
    }

    public void graphics()
    {

        QualitySettings.SetQualityLevel(quality.value, false);
        int qualityLevel = QualitySettings.GetQualityLevel();
       // Debug.Log("quality: " + qualityLevel);


    }
    public void resolution()
    {
        //Debug.Log(Resolution.value);
        if (Resolution.value == 0)
        {
            //Debug.Log("LOWER_resolution");
            Screen.SetResolution(960, 540, true);
        }
        else if(Resolution.value == 1)
        {
            Screen.SetResolution(1280, 720, true);

        }
        else if (Resolution.value == 2)
        {
            Screen.SetResolution(1920, 1080, true);
        }
        else if (Resolution.value == 3)
        {
            Screen.SetResolution(2560, 1440, true);
        }
        else if (Resolution.value == 4)
        {
            Screen.SetResolution(3840, 2160, true);
        }
        else if (Resolution.value == 5)
        {
            Screen.SetResolution(Display.main.systemWidth, Display.main.systemHeight, true);
        }

    }
  
    public void _ambient_acc()
    {
        if (ambient_acc.isOn)
        {
            //_ao.active(true);
            _ao.active=true;
        }
        else
        {
            _ao.active=false;
        }
    }

}
