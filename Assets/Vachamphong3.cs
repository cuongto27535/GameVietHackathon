using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vachamphong3 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy3;
    void Start()
    {
        enemy3.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            enemy3.SetActive(true);
        }
    }
}
