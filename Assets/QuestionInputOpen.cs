using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.SceneManagement;
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
            Debug.Log("Click");
            checkAnswerInput(answerInput);
        });
    }

    private void checkAnswerInput(InputField input)
    {
        if (input.text.ToString() == "")
        {
            Debug.Log("Nope");
        }
        else if (input.text.ToString() == "abc")
        {
            SceneManager.LoadScene("MenuChonMan");
        }
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
