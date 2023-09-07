using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionInputTouch1 : MonoBehaviour
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
            QuestionInputOpen1.Instance.showQuestion("Trong chiến dịch Huế -Đà Nẵng lực lượng phe ta gồm bao nhiêu sư đoàn bộ binh ?", "4");
        }
    }
    
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            QuestionInputOpen1.Instance.Hide();
        }
    }
}
