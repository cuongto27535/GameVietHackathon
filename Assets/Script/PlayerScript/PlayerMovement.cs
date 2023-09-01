using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Rigidbody2D rb;
    public Vector3 moveInput;
    public Animator animator;
    public SpriteRenderer charectorSR;
    [SerializeField] int maxHealth;
    int currentHealth;
    public HealthBar healthBar;
    public UnityEvent OnDeath;
    public ArmorBar armorBar;
    [SerializeField] int maxArmor;
    int currentArmor;

    private void OnEnable()
    {
        OnDeath.AddListener(Death);
    }

    void Start()
    {
        currentHealth = maxHealth;
        healthBar.UpdateBar(currentHealth, maxHealth);
        currentArmor = maxArmor;
        armorBar.UpdateBar(currentArmor, maxArmor);

    }

    void Update()
    {
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");
        transform.position += moveInput * moveSpeed * Time.deltaTime;

        animator.SetFloat("status", moveInput.sqrMagnitude);
        
        if (moveInput.x != 0)
        {
            AudioManager.Instance.PlaySFX("run");

            if (moveInput.x > 0)
                charectorSR.transform.localScale = new Vector3(1, 1, 0);
            else
                charectorSR.transform.localScale = new Vector3(-1, 1, 0);
        }
    }
    
    public void TakeDamage(int damage)
    {
        currentArmor -= damage;
        if (currentArmor < 0)
        {
            currentHealth -= damage;
            if (currentHealth <= 0)
            {
                currentHealth = 0;
                OnDeath.Invoke();
            }
            healthBar.UpdateBar(currentHealth, maxHealth);
        }
        armorBar.UpdateBar(currentArmor, maxArmor);
    }
    
    public void Death()
    {
        Destroy(gameObject);
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("bulletEnemy"))
        {
            TakeDamage(1);
        }
    }
    
}
