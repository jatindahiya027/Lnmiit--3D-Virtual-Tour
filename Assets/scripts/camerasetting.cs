using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.UI;
public class camerasetting : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    Toggle ambient_acc;
    [SerializeField]
    Toggle _motionblurr;


    private PostProcessVolume _postprocessvolume;
    private AmbientOcclusion _ao;
    private MotionBlur _mb;
    void Start()
    {
        _postprocessvolume = GetComponent<PostProcessVolume>();
        _postprocessvolume.profile.TryGetSettings(out _ao);
        _postprocessvolume.profile.TryGetSettings(out _mb);
    }

    public void _ambient_acc()
    {
        if (ambient_acc.isOn)
        {
            //_ao.active(true);
            _ao.active = true;
            //_mb.active = true;
        }
        else
        {
            _ao.active = false;
            //_mb.active = false;
        }
    }
    public void _motionblur()
    {
        if (_motionblurr.isOn)
        {
            //_ao.active(true);
            ////_ao.active = true;
            _mb.active = true;
        }
        else
        {
            //_ao.active = false;
            _mb.active = false;
        }
    }
}
