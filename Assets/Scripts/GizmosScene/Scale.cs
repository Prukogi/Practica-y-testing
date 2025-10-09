using UnityEngine;

public class Scale : MonoBehaviour
{
    //Public Attributes
    public float scaleX;
    void Start()
    {
        //transform.position = new Vector3(5, transform.position.y, transform.position.z);
    }

    void Update()
    {
        
        transform.localScale = new Vector3(1, scaleX, transform.localScale.z);
    }
}
