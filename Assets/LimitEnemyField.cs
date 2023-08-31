using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LimitEnemyField : MonoBehaviour
{
    public GameObject enemy;
    void Start()
    {
        enemy.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            enemy.SetActive(true);
        }
    }
}
