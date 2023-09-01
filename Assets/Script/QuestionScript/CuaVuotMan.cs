using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuaVuotMan : MonoBehaviour

{
  public GameObject cavasGoiy;

    private void Start()
    {
        cavasGoiy.SetActive(false);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            cavasGoiy.SetActive(true);
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        cavasGoiy.SetActive(false) ;
    }


}
