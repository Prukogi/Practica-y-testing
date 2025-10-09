using UnityEngine;

public class LookAt : MonoBehaviour
{
    //Public Attributes
    public Transform target;
    void Start()
    {
        print("target x: " + target.position.x + " / Target y: " + target.position.y + " / target z: " + target.position.z);
    }
    void Update()
    {
        
        transform.LookAt(target.position);
    }
}
