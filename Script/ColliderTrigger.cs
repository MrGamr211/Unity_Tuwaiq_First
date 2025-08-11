using Unity.VisualScripting;
using UnityEngine;

public class ColliderTrigger : MonoBehaviour
{
    public GameObject Door;
    public AudioClip Open;
    public AudioClip Close;
    public AudioSource DoorAuClose;
    public AudioSource DoorAuOpen;
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
            DoorAuClose.Play();
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
            DoorAuOpen.Play();
        }
    }
}
