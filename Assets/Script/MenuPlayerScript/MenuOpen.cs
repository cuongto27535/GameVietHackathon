using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class MenuOpen : MonoBehaviour
{
    public Button resumeBtn, homeBtn, settingBtn;

    public static MenuOpen Instance
    {
        get;
        private set;
    }
    void Start()
    {
        Instance = this;
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showMenu(Action resume, Action home, Action setting)
    {
        gameObject.SetActive(true);
        resumeBtn.onClick.AddListener(new UnityAction(resume));
        homeBtn.onClick.AddListener(new UnityAction(home));
        settingBtn.onClick.AddListener(new UnityAction(setting));
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
