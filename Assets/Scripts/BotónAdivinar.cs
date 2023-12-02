using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotónAdivinar : MonoBehaviour
{
    public void OnButtonClickedButton()
    {
        // Esto obtiene el GameObject al que está adjunto este script (en este caso, el botón)
        GameObject objetoPulsado = gameObject; 
        // Llamar al método que necesita el parámetro GameObject
        OnButtonClicked(objetoPulsado);
    }

    public void OnButtonClicked(GameObject objetoPulsado)
    {
        Debug.Log("Estoy en botonAdivinar");
        PJ personaje = objetoPulsado.GetComponent<PJ>();
        if (personaje != null && personaje.id == 1)
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
    }

    void MostrarMensajePerdedor()
    {
        Debug.Log("¡Has perdido!");
    }
}
