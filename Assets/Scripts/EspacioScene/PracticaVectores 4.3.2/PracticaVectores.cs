using UnityEngine;



public class PracticaVectores : MonoBehaviour
{
    //Public Attributes
    public Transform playerTransform;
    public Transform sphereTransform;

    public float velocidadz;
    public float velocidady;
    public float velocidadRotacion;
    public float velocidadRotacionEsfera;


    //Private Attributes
    private float anguloRotacion = 0;



    //Methods
    void Start()
    {
    }
    void Update()
    {
        //Movimiento en 2 ejes 1 metodo
        //playerTransform.Translate(0, Time.deltaTime * velocidady, Time.deltaTime * velocidadz);
        
        //Movimiento en 2 ejes otro metodo
        playerTransform.Translate(Vector3.forward * Time.deltaTime * velocidadz);
        playerTransform.Translate(Vector3.up * Time.deltaTime * velocidady);

        //Rotación en 1 eje
        //playerTransform.Rotate(velocidadRotacion * Time.deltaTime, 0, 0);
        playerTransform.Rotate(Vector3.right * velocidadRotacion * Time.deltaTime);


        //Rotate Around
        sphereTransform.RotateAround(playerTransform.position, Vector3.forward, anguloRotacion * Time.deltaTime * velocidadRotacionEsfera);

        anguloRotacion++;
    }

}
