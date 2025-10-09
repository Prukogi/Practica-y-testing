using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
    //Public Attributes
    public int numero2 = 5;
    public static int numero3 = 25; //Variables staticas, pertenecen a la clase y no a la instancia

    //Private Attributes
    //[SerializeField] //Permite ver la variable en el inspector de Unity a pesar de ser privada
    private int _numero1 = 0;
    
    
    //Methods
    void Start()
    {
    
    }
     public static string funcionEstatica()
    {
        print("Funcion estatica");
        return "Funcion estatica";
    }

    public void funcionPublica() 
    { 
        print("Funcion publica");
    }
    void Update()
    {
        print(_numero1);
    }
    
}
