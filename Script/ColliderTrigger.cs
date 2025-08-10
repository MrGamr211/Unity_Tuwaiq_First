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
        Door.SetActive(false);
    }
    public void OnTriggerExit(Collider other)
    {
        Door.SetActive(true);
    }

}
