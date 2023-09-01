using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoiYVuotMan : MonoBehaviour
{
    public GameObject goiY;
    void Start()
    {
        goiY.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            goiY.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        goiY.SetActive(false) ;
    }
}
