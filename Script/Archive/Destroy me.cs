using Unity.VisualScripting;
using UnityEngine;

public class Destroyme : MonoBehaviour
{

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject); //Destroy self
            //Destroy(collision.gameObject); Destroy the collided
        }
    }
}
