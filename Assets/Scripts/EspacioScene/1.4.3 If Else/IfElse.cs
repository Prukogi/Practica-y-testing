using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElse : MonoBehaviour
{
    //Public Attributes
    public int numero1;
    public int numero2;
    public int numero3;

    //Private Attributes
    private int _numeromayor;


    //Methods
    void Start()
    {
        if (numero1 > numero2 && numero1 > numero3)
        {
            _numeromayor = numero1;
        }
        else if(numero2 > numero1 && numero2 > numero3) 
        {
            _numeromayor = numero2; 
        }
        else if(numero3 > numero1 && numero3 > numero2)
        {
            _numeromayor = numero3;
        }
        Debug.Log("El numero mayor es: " + _numeromayor);

    }



}
