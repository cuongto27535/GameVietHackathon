using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vachamphong : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject enemy;
    void Start()
    {
        enemy.SetActive(false);
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
         if(collision.gameObject.CompareTag("Player")){
            enemy.SetActive(true);
        }
    }
}
