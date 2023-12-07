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
    public GameObject canvaGanador;
    public GameObject canvaPerdedor;
    
    void Start()
    {
        if (canvaGanador != null)
        {
            canvaGanador.SetActive(false);
            canvaPerdedor.SetActive(false);
        }
        else
        {
            Debug.LogError("El canvas no está asignado en el Inspector.");
        }
    }
    
    public void ActivarSeleccion()
    {
        esperandoSeleccion = true;
    }

    public void TocarObjetoPJ(int IDPulsado, int numeroGanador)
    {
        esperandoSeleccion = false;
       if (IDPulsado != 0)
    {
        if (IDPulsado == numeroGanador)
        {
            canvaGanador.SetActive(true); // Muestra un mensaje de victoria si el ID coincide
            canvaPerdedor.SetActive(false);
        }
        else
        {
            canvaPerdedor.SetActive(true); // Muestra un mensaje de derrota si el ID no coincide
            canvaGanador.SetActive(false);
        }
    }
    else
    {
        Debug.LogError("PJ script not found on the objetoPulsado GameObject.");
    }
}
}
