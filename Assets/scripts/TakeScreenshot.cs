using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

public class TakeScreenshot : MonoBehaviour
{
    [SerializeField]
    private GameObject Navbar_obj;

    // Use this for initialization
   // public void Screenshot()
   // {
        
    //    StartCoroutine(UploadPNG());
        //Debug.log (encodedText);
   // }
    public void ScreenshotPC()
    {
#if UNITY_STANDALONE
        //Navbar_obj.SetActive(false);
        StartCoroutine(takescreenshot());
        //Debug.log (encodedText);
#elif UNITY_EDITOR
        StartCoroutine(takescreenshot());

#elif UNITY_WEBGL
        StartCoroutine(UploadPNG());
#endif
    }

    IEnumerator takescreenshot() {
        yield return new WaitForEndOfFrame();
        ScreenCapture.CaptureScreenshot(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop) + "/Screenshot" + Time.frameCount + ".png");
        //Debug.Log(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Desktop));
       // Navbar_obj.SetActive(false);
        //Cursor.visible = false;
        //Cursor.lockState = CursorLockMode.Locked;
        //Time.timeScale = 1f;
    }
#if UNITY_WEBGL
     IEnumerator UploadPNG()
    {
    // We should only read the screen after all rendering is complete
       yield return new WaitForEndOfFrame();

    // Create a texture the size of the screen, RGB24 format
      int width = Screen.width;
       int height = Screen.height;
      var tex = new Texture2D(width, height, TextureFormat.RGB24, false);

    // Read screen contents into the texture
      tex.ReadPixels(new Rect(0, 0, width, height), 0, 0);
      tex.Apply();

    // Encode texture into PNG
     byte[] bytes = tex.EncodeToPNG();
      Destroy(tex);

    //string ToBase64String byte[]
     string encodedText = System.Convert.ToBase64String(bytes);

      var image_url = "data:image/png;base64," + encodedText;
    //Navbar_obj.SetActive(false);
     //Time.timeScale = 1f;
    // Cursor.visible = false;
    // Cursor.lockState = CursorLockMode.Locked;
    //Debug.Log(image_url);

//#if !UNITY_EDITOR
     openWindow(image_url);
//#endif
     }

     [DllImport("__Internal")]
     private static extern void openWindow(string url);
#endif
}