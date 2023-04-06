using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AsyncSceneLoader : MonoBehaviour
{
    //public string sceneName;
    //public string sceneNames;
    //public string[] triggerTags;
    [SerializeField]
    GameObject player;
    [SerializeField]
    int distance;

    int check = 0;
    private void FixedUpdate()
    {   if(check==1)
        if (Vector3.Distance(player.transform.position, this.transform.position) > distance)
        {
            StartCoroutine(UnloadScene(this.gameObject.name));
                check = 0;
        }
    }
    void OnTriggerEnter(Collider other)
    {   if(other.tag=="Player")
        
          
                StartCoroutine(LoadScene(this.gameObject.name));
        check = 1;         
        
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
            
               
                    StartCoroutine(UnloadScene(this.gameObject.name));
        check = 0;
                    
                
    }

    IEnumerator LoadScene(string sceneName)
    {
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync(sceneName, LoadSceneMode.Additive);

        // Wait until the asynchronous scene fully loads
        while (!asyncLoad.isDone)
        {
            yield return null;
        }
    }
    IEnumerator UnloadScene(string sceneName)
    {
        AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync(sceneName);

        // Wait until the asynchronous scene fully unloads
        while (!asyncUnload.isDone)
        {
            yield return null;
        }

        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(0));
    }
}
