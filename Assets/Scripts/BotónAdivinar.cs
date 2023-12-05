using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotónAdivinar : MonoBehaviour
{
    public IdPJGanador idpjganador;
    public bool esperandoSeleccion = false;

    public void ActivarSeleccion()
    {
        esperandoSeleccion = true;
    }

    public void TocarObjetoPJ(GameObject objetoPulsado, int numeroGanador)
    {

        Debug.Log("ESTOY EN TOCAROBJETOPJ");
        Debug.Log(numeroGanador);
        esperandoSeleccion = false;
        PJ pj = objetoPulsado.GetComponent<PJ>();
        if (pj != null && pj.id == numeroGanador)
        {
            MostrarMensajeGanador(); // Muestra un mensaje de victoria si el ID coincide
        }
        else
        {
            MostrarMensajePerdedor(); // Muestra un mensaje de derrota si el ID no coincide
        }
    }

   
    void MostrarMensajeGanador()
    {
        Debug.Log("¡Has ganado!");
        // Implementa aquí la lógica para mostrar un mensaje de victoria en la pantalla principal
    }

    void MostrarMensajePerdedor()
    {
        Debug.Log("¡Has perdido!");
        // Implementa aquí la lógica para mostrar un mensaje de derrota en la pantalla principal
    }
}
