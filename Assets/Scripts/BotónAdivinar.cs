using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotónAdivinar : MonoBehaviour
{
    IdPJGanador idPJGanador;   
    public bool esperandoSeleccion = false;

    public void ActivarSeleccion()
    {
        esperandoSeleccion = true;
    }

    public void TocarObjetoPJ(GameObject objetoPulsado)
    {
        esperandoSeleccion = false;
        Debug.Log("ESTOY EN TOCAROBJETOPJ");
        PJ pjScript = objetoPulsado.GetComponent<PJ>();
       if (pjScript != null)
    {
        Debug.Log(pjScript.id);

        if (pjScript.id == idPJGanador.numeroGanador)
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
