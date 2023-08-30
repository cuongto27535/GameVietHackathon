using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionControl : MonoBehaviour
{
    public float Time;
    void Start()
    {
        Destroy(this.gameObject, Time);
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
   {
        if (other.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);

        }
        if (other.gameObject.CompareTag("vatcan"))
        {
            Destroy(gameObject);

        }
    }
}
