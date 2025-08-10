using Unity.VisualScripting;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public GameObject Door;
    public AudioClip Open;
    public AudioClip Close;
    void Start()
    {

    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Coin") // blackList
        {
            // blackList
        }
        else
        {
            Door.SetActive(false);
        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.tag == "Coin") // blackList
        {
            // blackList
        }
        else
        {
            Door.SetActive(true);
        }
    }

}
