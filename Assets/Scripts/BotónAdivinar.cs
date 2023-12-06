using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class BotónAdivinar : MonoBehaviour
{
    public IdPJGanador idPJGanador;
    public bool esperandoSeleccion = false;
    public MostrarMensajes mostrarMensajes;

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
            mostrarMensajes.MostrarMensajeGanador(); // Muestra un mensaje de victoria si el ID coincide
        }
        else
        {
            mostrarMensajes.MostrarMensajePerdedor(); // Muestra un mensaje de derrota si el ID no coincide
        }
    }
    else
    {
        Debug.LogError("PJ script not found on the objetoPulsado GameObject.");
    }
}
}
