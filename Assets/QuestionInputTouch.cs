using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionInputTouch : MonoBehaviour
{
    // Start is called before the first frame update
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
            QuestionInputOpen.Instance.showQuestion("Chiếc xe tăng dẫn đầu đánh chiếm Dinh độc lập mang số bao nhiêu?", "390");
        }
    }
    
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            QuestionInputOpen.Instance.Hide();
        }
    }
}
