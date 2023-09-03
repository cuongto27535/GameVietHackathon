using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vachamphong2 : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy2;
    void Start()
    {
        enemy2.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Player")){
            enemy2.SetActive(true);
        }
    }
}
