using UnityEngine;

public class Movement_Rotation : MonoBehaviour
{
    public Rigidbody player;


    void Start()
    {
        player = gameObject.GetComponent<Rigidbody>();
    }
    
    Vector3 Rotate_X = Input.mousePosition;






    void Update()
    {
        player.gameObject.transform.rotation = Quaternion.Euler(new Vector3(0, Rotate_X.x * 0.01f, 0));

        if (Input.GetKey(KeyCode.W))
        {
            player.AddForce(new Vector3(0, 0, 5), ForceMode.Force);
        }
    }
}
