using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bunhin : MonoBehaviour
{
    int bunhindungim = 0;
    int bunhintrungdan = 1;
    public Animator bunhinAnin;
    public float timeAnin=1f;
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            StartCoroutine(changeAnim());
           
            Destroy(collision.gameObject);
        }
    }

    IEnumerator changeAnim()
    {
        bunhinAnin.SetInteger("bunhinstatus", bunhintrungdan);
        yield return new WaitForSeconds(0.2f);
        bunhinAnin.SetInteger("bunhinstatus", bunhindungim);
    }
    

}
