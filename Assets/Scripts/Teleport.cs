using UnityEngine;

public class Teleport : MonoBehaviour
{
    public Transform teleportTarget;
    public GameObject target;

    public void OnTriggerEnter(Collider other)
    {
        target.transform.position = teleportTarget.transform.position;
    }
}