using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MenuOnClick : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Open()
    {
        MenuOpen.Instance.showMenu(() =>
        {
            MenuOpen.Instance.Hide();
        }, () =>
        {
            SceneManager.LoadScene("Menu");
        }, () =>
        {
            Debug.Log("Setting");
        });
    }
}
