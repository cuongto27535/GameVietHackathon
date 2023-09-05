using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionInputTouch2 : MonoBehaviour
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
            QuestionInputOpen2.Instance.showQuestion("Mật danh của chiến dịch Tây Nguyên là ?", "275");
        }
    }
    
    private void OnCollisionExit2D(Collision2D other) {
        if(other.gameObject.CompareTag("Player")){
            QuestionInputOpen2.Instance.Hide();
        }
    }
}
