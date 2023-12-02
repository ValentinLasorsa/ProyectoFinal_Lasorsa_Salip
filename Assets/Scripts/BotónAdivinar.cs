using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotónAdivinar : MonoBehaviour
{
    private GameObject objetoSeleccionado;

    public void OnButtonClicked()
    {
        // Raycast desde la posición del ratón en la pantalla
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            // Verifica si el objeto golpeado tiene el componente PJ
            PJ personaje = hit.collider.GetComponent<PJ>();

            if (personaje != null)
            {
                objetoSeleccionado = hit.collider.gameObject;

                int numeroAleatorio = Random.Range(0, 11);
                Debug.Log(numeroAleatorio);

                if (personaje.id == numeroAleatorio)
                {
                    MostrarMensajeGanador(); // Muestra un mensaje de victoria si el ID coincide
                }
                else
                {
                    MostrarMensajePerdedor(); // Muestra un mensaje de error si el ID no coincide
                }
            }
        }
    }

    void MostrarMensajeGanador()
    {
        Debug.Log("¡Has ganado!");
        // Implementa la lógica para mostrar un mensaje de victoria en la pantalla principal
    }

    void MostrarMensajePerdedor()
    {
        Debug.Log("¡Has perdido!");
        // Implementa la lógica para mostrar un mensaje de error en la pantalla principal
    }
}
