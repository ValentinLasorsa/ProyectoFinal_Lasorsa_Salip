using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class BotónAdivinar : MonoBehaviour
{
    bool esperandoSeleccion = false;
    int idEsperado = 1; // ID que se espera para mostrar el mensaje de ganador

    void Update()
    {
        if (esperandoSeleccion && Input.GetMouseButtonDown(0)) // Si se está esperando la selección y se hace clic
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                GameObject objetoPulsado = hit.collider.gameObject;
                TocarObjetoPJ(objetoPulsado);
            }
        }
    }

    public void ActivarSeleccion()
    {
        esperandoSeleccion = true;
    }

    void TocarObjetoPJ(GameObject objetoPulsado)
    {
        Debug.Log("ESTOY EN TOCAROBJETOPJ");
        esperandoSeleccion = false;

        PJ personaje = objetoPulsado.GetComponent<PJ>();
        if (personaje != null && personaje.id == idEsperado)
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
