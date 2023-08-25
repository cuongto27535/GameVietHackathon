using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BoxTouch : MonoBehaviour
{
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            QuestionOpen.Instance.showQuestion("abc", () =>
            {
                SceneManager.LoadScene("Man2");
            }, () =>
            {
                Debug.Log("Error Answer");
                QuestionOpen.Instance.Hide();
            });
            
        }
    }
}
