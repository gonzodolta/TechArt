using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public GameObject particleObject;
    public HealthScript healthScript;



    void OnTriggerEnter(Collider collider)
    {
        if (collider.CompareTag("Player"))
        {
            healthScript.TakeDamage(20);
            Instantiate(particleObject, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

}
