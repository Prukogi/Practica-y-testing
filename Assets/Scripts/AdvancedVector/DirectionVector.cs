using UnityEngine;

public class DirectionVector: MonoBehaviour
{
    //Public Attributes
    public Transform finalTransform;
    public Transform initialTransform;
    public float speed = 1f;

    //Private Attributes
    private Vector3 _directionVector;
    //Methods
    void Start()
    {
    }

    
    void Update()
    {
        //Calculo del Vector Direccion
        _directionVector = finalTransform.position - initialTransform.position;
        
        //Convierte el vector en unitario
        _directionVector.Normalize();
        
        //Dibujamos el vector
        Debug.DrawRay(initialTransform.position, _directionVector * speed);
        
        //Translate
        initialTransform.Translate(_directionVector * Time.deltaTime * speed);
        
        //Magnitude
        print("Magnitud: " + _directionVector.magnitude * speed);
        
        //Distance
        float distance = Vector3.Distance(initialTransform.position, finalTransform.position);
        print("Distance: " + distance);
        if (distance < 10 || distance > 20) 
        { 
            speed *= -1; 
        }

        
    }
}
