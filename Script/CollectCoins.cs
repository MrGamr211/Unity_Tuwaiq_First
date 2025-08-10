using Unity.VisualScripting;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
     int CoinsCollected;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject); //Destroy self
            CoinsCollected++;
            Debug.Log(CoinsCollected);
            //Destroy(collision.gameObject); Destroy the collided
            //return CoinsCollected;

        }
    }
}
