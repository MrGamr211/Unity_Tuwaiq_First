using Unity.VisualScripting;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public GameObject Door;
    void Start()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        Destroy(Door);
    }
}
