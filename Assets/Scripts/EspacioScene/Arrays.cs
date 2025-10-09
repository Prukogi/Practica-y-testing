using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrays : MonoBehaviour
{
    //Public Attributes
    public bool SumaLista = false;

    //Private Attributes
    private int[] _numeros = {1,2,3,4,5};
    private int _totalLista = 0;
    //Methods
    void Start()
    {
           
    }
    void Update()
    {
        if (SumaLista == true)
        {
            CalculoLista();
            SumaLista = false;
        }
    }
    private void CalculoLista() 
    {
        _totalLista = _numeros[0] + _numeros[1] + _numeros[2] + _numeros[3] + _numeros[4];
        Debug.Log("El total de la lista es: " + _totalLista);
    }
}

