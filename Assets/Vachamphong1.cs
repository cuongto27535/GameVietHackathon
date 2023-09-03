using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vachamphong1 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy1;
    void Start()
    {
        enemy1.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            enemy1.SetActive(true);
        }
    }
}
