using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;
using UnityEngine.TextCore.Text;
using UnityEngine.Events;

public class EnemyAI : MonoBehaviour
{
    public Transform target;

    public float moveSpeed = 2f;
    public float nextWayPointDistance = 2f;
    public float repeatTimeUpdatePath = 0.5f;
    public SpriteRenderer characterSR;
    public Animator animator;

    public UnityEvent OnDeathEnemy;
    public GameObject bullet;
    public float bulletSpeed;
    public float timeBullet;
    public float fireCooldown;

    [SerializeField] int maxHealthEnemy;
    int currentHealthenemy;


    Path path;
    Seeker seeker;
    Rigidbody2D rb;
   

    Coroutine moveCoroutine;

    // Part 10
    public float freezeDurationTime;
    float freezeDuration;

    private void OnEnable()
    {
        OnDeathEnemy.AddListener(DeathEnemy);
    }
    private void Start()
    {
        currentHealthenemy = maxHealthEnemy;
        seeker = GetComponent<Seeker>();
        rb = GetComponent<Rigidbody2D>();
        freezeDuration = 0;
        target = FindObjectOfType<PlayerMovement>().transform;

        InvokeRepeating("CalculatePath", 0f, repeatTimeUpdatePath);

    }

    private void Update()
    {
        fireCooldown -= Time.deltaTime;
        if(fireCooldown < 0)
        {
            fireCooldown = timeBullet;
            EnemyFire();
        }
    }

    void EnemyFire()
    {
        var enemybullet = Instantiate(bullet, transform.position, Quaternion.identity);
        Rigidbody2D rb =enemybullet.GetComponent<Rigidbody2D>();
        Vector3 playerPos =FindObjectOfType<PlayerMovement>().transform.position;
        Vector3 direction =playerPos - transform.position;
        rb.AddForce(direction.normalized*bulletSpeed,ForceMode2D.Impulse);
    }
    void CalculatePath()
    {
        if (seeker.IsDone())
            seeker.StartPath(rb.position, target.position, OnPathCompleted);
    }

    void OnPathCompleted(Path p)
    {
        if (!p.error)
        {
            path = p;
            MoveToTarget();
        }
    }

    void MoveToTarget()
    {
        if (moveCoroutine != null) StopCoroutine(moveCoroutine);
        moveCoroutine = StartCoroutine(MoveToTargetCoroutine());
    }

    public void FreezeEnemy()
    {
        freezeDuration = freezeDurationTime;
    }

    IEnumerator MoveToTargetCoroutine()
    {
        int currentWP = 0;

        while (currentWP < path.vectorPath.Count)
        {
            while (freezeDuration > 0)
            {
                freezeDuration -= Time.deltaTime;
                yield return null;
            }

            Vector2 direction = ((Vector2)path.vectorPath[currentWP] - rb.position).normalized;
            Vector2 force = direction * moveSpeed * Time.deltaTime;
            transform.position += (Vector3)force;

            float distance = Vector2.Distance(rb.position, path.vectorPath[currentWP]);
            if (distance < nextWayPointDistance)
                currentWP++;

            if (force.x != 0)
                if (force.x < 0)
                    characterSR.transform.localScale = new Vector3(-1, 1, 0);
                else
                    characterSR.transform.localScale = new Vector3(1, 1, 0);

            yield return null;
        }
    }
    public void TakeDamageEnemy(int damageEnymy)
    {
        currentHealthenemy -= damageEnymy;
        if (currentHealthenemy <= 0)
            {
                currentHealthenemy = 0;
               OnDeathEnemy.Invoke();

        }
           
        }
    public void DeathEnemy()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bullet"))
        {
            TakeDamageEnemy(1);

        }
    }




}