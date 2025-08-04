// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class EnemyMove : MonoBehaviour
// {
//     public Transform A;
//     public Transform B;
//     // Start is called before the first frame update
//     void Start()
//     {
//         transform.LookAt(A);

//     }
//     void Update()
//     {
//         transform.Translate(Vector3.forward*Time.deltaTime);
//     }
//     void OnTriggerEnter(Collider other)
//     {
//         if (other.gameObject.tag == "A")
//         {
//             transform.LookAt(B);
//             Debug.Log("AAAAAAAAAAAAAAAAAAAAA");
//     }
//         if (other.gameObject.tag == "B")
//         {
//             transform.LookAt(A);
//            Debug.Log("BBBBBBBBBBBBBBBBBBBBBB");
//     }
//     }


// }


using UnityEngine;

public class EnemyMove : MonoBehaviour
{
    public Transform A;
    public Transform B;



    void Start()
    {
        transform.LookAt(A);
    }
    void Update()
    {
        transform.Translate(Vector3.forward * 0.5f * Time.fixedDeltaTime);
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "A")
        {
            transform.LookAt(B);
            Debug.Log("Breaking Bad is Vary Bad, But It's AAAAAAAAAAAAAAAAAA");
        } 
        else if (other.gameObject.tag == "B") {
            transform.LookAt(A);
            Debug.Log("Breaking Bad is Vary Bad, But It's BBBBBBBBBBBBBBBBBB");
         } 
    }
}
