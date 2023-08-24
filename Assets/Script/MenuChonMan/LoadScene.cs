using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadScene : MonoBehaviour
{
    public GameObject loadingScene;
    public Slider loadBar;
    public void Start()
    {
        loadingScene.SetActive(false);
    }
    public  void Loadding(int scenelevel) 
    {
        StartCoroutine(Load(scenelevel));

     }
    
    IEnumerator Load(int scenelevel)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(scenelevel);
            loadingScene.SetActive(true);
            while (!operation.isDone)
            {
                loadBar.value = operation.progress;
                yield return null;
            }

        
    }
}
