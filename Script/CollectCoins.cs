using Unity.VisualScripting;
using UnityEngine;

public class CollectCoins : MonoBehaviour
{
    private int CoinsCollected;
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject); //Destroy self
            CoinsCollected += 1;
            Debug.Log(CoinsCollected);
            //Destroy(collision.gameObject); Destroy the collided


        }
    }
}
