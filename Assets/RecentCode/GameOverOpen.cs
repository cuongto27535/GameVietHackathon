using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverOpen : MonoBehaviour
{
    public static GameOverOpen Instance
    {
        get;
        private set;
    }

    public Button homeBtn, replayBtn;
    void Start()
    {
        Instance = this;
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Show()
    {
        gameObject.SetActive(true);
        homeBtn.onClick.AddListener(new UnityAction(() =>
        {
            SceneManager.LoadScene("Menu");
        }));
        replayBtn.onClick.AddListener(new UnityAction((() =>
        {
            SceneManager.LoadScene("Man2");
        })));
    }
}
