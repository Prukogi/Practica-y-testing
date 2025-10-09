using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucleFor : MonoBehaviour
{
    //Public Attributes
    public int Fibonacci;
    
    
    
    //Private Attributes
    
    string _serieCompletaFibonacci = string.Empty;

    //Methods
    

    void Start()
    {
        calculaSerieFibonacci();
    }
    void calculaSerieFibonacci()
    {
        int _x1 = 0;
        int _x2 = 1;
        int _x3 = 0;
        _serieCompletaFibonacci = "";
        for (int i = 0; i < Fibonacci; i++)
        {
            _x3 = _x1 + _x2;
            _x1 = _x2;
            _x2 = _x3;
            _serieCompletaFibonacci += _x3.ToString() + ", ";
        }
        print(_serieCompletaFibonacci);
    }

}
