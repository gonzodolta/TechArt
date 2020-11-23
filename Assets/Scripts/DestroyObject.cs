using UnityEngine;

public class DestroyObject : MonoBehaviour
{
    public float time;

    private void Start() => Destroy(gameObject, time);

}