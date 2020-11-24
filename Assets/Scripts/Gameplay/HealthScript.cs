using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{
    public GameObject particleObject;
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;
    public HealthBar healthBar;

    public static int currentHealth = 80;

    Vector3 posOffset;
    Vector3 tempPos;


    void Start()

    {
        posOffset = transform.position;
    }


    void Update()
    {
        transform.Rotate(new Vector3(0f, Time.deltaTime * degreesPerSecond, 0f), Space.World);
        tempPos = posOffset;
        tempPos.y += Mathf.Sin(Time.fixedTime * Mathf.PI * frequency) * amplitude;
        transform.position = tempPos;
    }



    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            PlusHealth(20);
            Instantiate(particleObject, collider.transform.position, Quaternion.identity, collider.transform) ;
            Destroy(gameObject);
        }
    }
    public void PlusHealth(int health)
    {
        currentHealth += health;
        healthBar.SetHealth(currentHealth);
    }
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}

