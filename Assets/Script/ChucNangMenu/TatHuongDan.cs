using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TatHuongDan : MonoBehaviour
{
    public GameObject canvasObject;
    void Start()
    {
        canvasObject.SetActive(true);
    }
    public void Huongdan()
    {
        canvasObject.SetActive(false);
    }
}
