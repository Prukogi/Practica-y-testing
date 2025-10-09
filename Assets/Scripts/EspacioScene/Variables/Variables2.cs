using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables2 : MonoBehaviour
{
    //Public Attributes
    public Variables Variables;


    //Private Attributes



    //Methods
    void Start()
    {
        Variables = gameObject.GetComponent<Variables>();
        print("Numero1: " + Variables.numero2);
        print("Numero2: (static) " + Variables.numero3);
        print("funcion: (static) " + Variables.funcionEstatica());

    }



    void Update()
    {
        
    }
}
