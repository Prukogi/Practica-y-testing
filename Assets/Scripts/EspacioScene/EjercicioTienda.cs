using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EjercicioTienda : MonoBehaviour
{
    //Public Attributes
    public float saldo = 1000;
    public int carritoCompra = 0;
    public int cantidadOro = 0;
    public int cantidadPlata = 0;
    public int cantidadBronce = 0;

    public bool RealizarCompra = false;
    public bool SeleccionarOro = false;
    public bool SeleccionarPlata = false;
    public bool SeleccionarBronce = false;
    public bool CancelarOro = false;
    public bool CancelarPlata = false;
    public bool CancelarBronce = false;
    public bool VaciarCarrito = false;




    //Private Attributes
    private int _precioOro = 250;
    private int _precioPlata = 150;
    private int _precioBronce = 50;

    //Methods
    void Start() 
    {
       Debug.Log("Bienvenido a la tienda, su saldo es de: " + saldo);
    }
    void Update()
    {
        if (SeleccionarOro == true)
        {
            carritoCompra += _precioOro;
            cantidadOro += 1;
            SeleccionarOro = false;
            Debug.Log("1 de oro añadido al carrito, el precio total a pagar es de: " + carritoCompra);
        }
        if (CancelarOro == true) 
        {
            if (cantidadOro <= 0)
            {
                Debug.Log("No tienes oro en el carrito");
            }
            else 
            {
                Debug.Log("1 de oro eliminado del carrito, el precio total a pagar es de: " + carritoCompra);
                cantidadOro -= 1;
                carritoCompra -= _precioOro;
            }
            CancelarOro = false;
        }
        
        if (SeleccionarPlata == true) 
        {
            carritoCompra += _precioPlata;
            cantidadPlata += 1;
            SeleccionarPlata = false;
            Debug.Log("1 de plata añadido al carrito, el precio total a pagar es de: " + carritoCompra);
        }
        if (CancelarPlata == true) 
        {
            if (cantidadPlata <= 0)
            {
                Debug.Log("No tienes plata en el carrito");
            }
            else 
            {
                Debug.Log("1 de plata eliminado del carrito, el precio total a pagar es de: " + carritoCompra);
                cantidadPlata -= 1;
                carritoCompra -= _precioPlata;
            }
            CancelarPlata = false;
        }



        if (SeleccionarBronce == true) 
        {
            carritoCompra += _precioBronce;
            cantidadBronce += 1;
            SeleccionarBronce = false;
            Debug.Log("1 de bronce añadido al carrito, el precio total a pagar es de: " + carritoCompra);
        }
        if (CancelarBronce == true) 
        {
            if (cantidadBronce <= 0)
            {
                Debug.Log("No tienes bronce en el carrito");
            }
            else 
            {
                Debug.Log("1 de bronce eliminado del carrito, el precio total a pagar es de: " + carritoCompra);
                cantidadBronce -= 1;
                carritoCompra -= _precioBronce;
            }
            CancelarBronce = false;
        }
        if (RealizarCompra == true) 
        {
            HacerCompra();
        }
        if (VaciarCarrito == true) 
        {
            cantidadOro = 0;
            cantidadPlata = 0;
            cantidadBronce = 0;
            carritoCompra = 0;
            Debug.Log("Carrito vaciado");
            VaciarCarrito = false;
        }
    }




    private void HacerCompra() 
    {
        if (saldo < carritoCompra) 
        {
            Debug.Log("No tienes suficiente saldo para realizar la compra, tu saldo es de: " + saldo + " y el precio total a pagar es de: " + carritoCompra);
        }
        else if (carritoCompra <= 0) 
        {
            Debug.Log("No tienes nada en el carrito");
        }
        else
        {
            saldo -= carritoCompra;
            Debug.Log("Compra realizada con exito, su nuevo saldo es de: " + saldo);
            cantidadOro = 0;
            cantidadPlata = 0;
            cantidadBronce = 0;
            carritoCompra = 0;
        }
        RealizarCompra = false;
    }








}
