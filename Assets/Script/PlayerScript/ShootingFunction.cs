using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootingFunction : MonoBehaviour
{
    public GameObject bullet;
    public Transform firePos;
    public float TimeBtwFire;
    public float bulletForce;
    
   
    public BulletBar bulletBar;
    [SerializeField] int maxBullet;
    int currentBullet;

    public GameObject fireEffect;

    private float timeBtwFire;

     void Start()
    {
        currentBullet = maxBullet;
        bulletBar.UpdateBar(currentBullet, maxBullet);
    }
    // Update is called once per frame
    void Update()
    {
        RotateGun();
        timeBtwFire -= Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
          
            if (currentBullet > 0)
            {
                Fire();
                currentBullet--;
               
            }
            bulletBar.UpdateBar(currentBullet, maxBullet);

        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            if (currentBullet < 30)
            {
                currentBullet = 30;
            }
            bulletBar.UpdateBar(currentBullet, maxBullet);
            AudioManager.Instance.PlaySFX("napdan");

        }
   void RotateGun()
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 lookDir = mousePos - transform.position;
            float angle = Mathf.Atan2(lookDir.y, lookDir.x) * Mathf.Rad2Deg;

            Quaternion rotation = Quaternion.Euler(0, 0, angle);
            transform.rotation = rotation;

            if (transform.eulerAngles.z > 90 && transform.eulerAngles.z < 270)
                transform.localScale = new Vector3(1, -1, 0);
            else transform.localScale = new Vector3(1, 1, 0);

        }
   void Fire()
        {
            timeBtwFire = TimeBtwFire;
            GameObject bulletTmp = Instantiate(bullet, firePos.position, Quaternion.identity);
            Instantiate(fireEffect, firePos.position, transform.rotation, transform);
            Rigidbody2D rb = bulletTmp.GetComponent<Rigidbody2D>();
            rb.AddForce(transform.right * bulletForce, ForceMode2D.Impulse);
            AudioManager.Instance.PlaySFX("bandan");


        }
    }
}
