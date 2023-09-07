using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class QuestionInputOpen2 : MonoBehaviour
{
    public static QuestionInputOpen2 Instance
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

    public void showQuestion(String questionTxt, String answerTxt)
    {
        gameObject.SetActive(true);
        questionText.text = questionTxt;
        insertBtn.onClick.AddListener(() =>
        {
            Debug.Log("Click");
            checkAnswerInput(answerInput, answerTxt);
        });
    }

    private void checkAnswerInput(InputField input, string answerInput)
    {
        if (input.text.ToString() == "")
        {
            Debug.Log("Nope");
        }
        else if (input.text.ToString() == answerInput)
        {
            SceneManager.LoadScene("Man3");
        }
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
