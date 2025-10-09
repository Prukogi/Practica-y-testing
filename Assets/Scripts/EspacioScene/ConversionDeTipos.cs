using System.Collections;
using System;
using UnityEngine;

public class ConversionDeTipos : MonoBehaviour
{
    /* 
    byte byte1 = 122; //8 bits
    short short1 = 123; //16 bits
    int int1 = 12; //32 bits
    double double1 = 35250; //64 bits
    bool bool1 = false; // 1 bit
    string string1 = "1234"; // cadena de texto
    */

    
    void Start()
    {
        //int1 = byte1; // Implicita, de menor a mayor
        //int1 = Int32.Parse(string1); // Explicita, de mayor a menor
        //string1 = int1.ToString() + double1.ToString(); // Explicita, de mayor a menor


        //Conversion de string a int
        string edad = "18";
        int Años = int.Parse(edad);
        Debug.Log(Años);
        //Conversion de string a float
        string float1 = "3,14";
        float float2 = float.Parse(float1);
        Debug.Log(float2 * 2 );
        //Conversion de int a double
        int num1 = 7;
        double num2 = num1;
        Debug.Log(num2 / 2);
        //Conversion de char a int
        char numChar = '5';
        int numInt = int.Parse(numChar.ToString());
        Debug.Log(numInt);
        //Suma de dos numeros en string
        string numero1 = "5";
        string numero2 = "2";
        int resultado = int.Parse(numero1) + int.Parse(numero2);
        Debug.Log(resultado);
    }

    

}
