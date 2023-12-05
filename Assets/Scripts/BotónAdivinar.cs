using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotónAdivinar : MonoBehaviour
{
    public IdPJGanador idPJGanador;
    public bool esperandoSeleccion = false;

    public void ActivarSeleccion()
    {
        esperandoSeleccion = true;
    }

    public void TocarObjetoPJ(int IDPulsado, int numeroGanador)
    {
        esperandoSeleccion = false;
        Debug.Log("ESTOY EN TOCAROBJETOPJ");
       if (IDPulsado != 0)
    {
        Debug.Log(IDPulsado);
        if (IDPulsado == numeroGanador)
        {
            MostrarMensajeGanador(); // Muestra un mensaje de victoria si el ID coincide
        }
        else
        {
            MostrarMensajePerdedor(); // Muestra un mensaje de derrota si el ID no coincide
        }
    }
    else
    {
        Debug.LogError("PJ script not found on the objetoPulsado GameObject.");
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
