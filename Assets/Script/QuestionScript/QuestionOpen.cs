using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class QuestionOpen : MonoBehaviour
{
    public Text questionText;
    public Button button_A, button_B;
    public static QuestionOpen Instance
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

    public void showQuestion(String question, Action answer_A, Action answer_B)
    {
        gameObject.SetActive(true);
        questionText.text = question;
        button_A.onClick.AddListener(new UnityAction(answer_A));
        button_B.onClick.AddListener(new UnityAction(answer_B));
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
