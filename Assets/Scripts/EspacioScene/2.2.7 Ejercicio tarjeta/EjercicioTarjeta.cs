using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioTarjeta : MonoBehaviour
{
    //Public Attributes
    public string _claveOficial = "123456";
    public string claveUsuario;
    public bool aceptar = false;

    //Private Attributes
    
    
    //Methods
    void Start()
    {
        
    }

    
    void Update()
    {
        if (aceptar) 
        { 
            Debug.Log("El pin introducido: " + claveUsuario);
            if (claveUsuario == _claveOficial)
            {
                Debug.Log("Clave correcta");
            }
            else 
            { 
                if(claveUsuario.Length < _claveOficial.Length || claveUsuario.Length > _claveOficial.Length)
                {
                    Debug.Log("El tamaño del PIN es incorrecto, la clave debe de ser de: " + _claveOficial.Length + "digitos");
                }
                else
                {
                    int n;
                    if (int.TryParse(claveUsuario, out n))
                    {
                        Debug.Log("La clave es incorrecta");
                    }
                    else 
                    { 
                        Debug.Log("El PIN solo puede contener numeros");
                    }
                }
            }
                aceptar = false;
        }
    }




    /*if (aceptar == true) 
        {
            if (clave == _claveOficial)
            {
                aceptar = false;
                Debug.Log("Clave correcta");
            }
            else if (clave != _claveOficial)
            {
                aceptar = false;
                Debug.Log("Clave incorrecta");
            }
            else if (clave.int.TryParse() != 4)
            {
                aceptar = false;
                Debug.Log("El tamaño del PIN es incorrecto");
            }
            /*else(clave.contains letters) 
            { 
                aceptar = false;
                Debug.Log("El PIN solo puede contener numeros");
            }
        }*/
}
