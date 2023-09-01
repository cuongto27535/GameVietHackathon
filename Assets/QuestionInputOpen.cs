using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class QuestionInputOpen : MonoBehaviour
{
    public static QuestionInputOpen Instance
    {
        get;
        private set;
    }

    public InputField answerInput;
    public Button insertBtn;
    public Text questionText;
    
    void Start()
    {
        Instance = this;
        Hide();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void showQuestion(String questionTxt)
    {
        gameObject.SetActive(true);
        questionText.text = questionTxt;
        insertBtn.onClick.AddListener(() =>
        {
            answerInput.onEndEdit.AddListener(checkAnswerInput);
        });
    }

    private void checkAnswerInput(string input)
    {
        if (string.IsNullOrEmpty(input))
        {
            Debug.Log("Nope");
        }
        else
        {
            Hide();
        }
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
