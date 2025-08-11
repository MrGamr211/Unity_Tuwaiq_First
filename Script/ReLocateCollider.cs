using UnityEngine;

public class ReLocateCollider : MonoBehaviour
{
    private Rigidbody Prop;
    public Transform Spawn;
    void Start()
    {

    }

    public void OnTriggerEnter(Collider OtherProp)
    {
        Prop.transform.parent = Spawn;
    }

}
