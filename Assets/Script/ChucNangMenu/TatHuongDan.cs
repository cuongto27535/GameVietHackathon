using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TatHuongDan : MonoBehaviour
{
    public GameObject canvasObject;
    void Start()
    {
        canvasObject.SetActive(true);
        Time.timeScale = 0;
    }
     void Update()
    {
        if(Input.GetKeyDown(KeyCode.F)) {
            canvasObject.SetActive(false);
            Time.timeScale = 1;
        }
    }
   
}
