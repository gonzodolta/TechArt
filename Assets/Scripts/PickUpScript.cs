using UnityEngine;

public class PickUpScript : MonoBehaviour
{
    public GameObject particleObject;
    public float degreesPerSecond = 15.0f;
    public float amplitude = 0.5f;
    public float frequency = 1f;

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
            Stats.theScore += 1;
            Instantiate(particleObject, collider.transform.position, Quaternion.identity, collider.transform) ;
            Destroy(gameObject);
        }
    }
}
