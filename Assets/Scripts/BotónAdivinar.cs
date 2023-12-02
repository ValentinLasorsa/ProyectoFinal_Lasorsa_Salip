using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BotónAdivinar : MonoBehaviour
{
    public void OnButtonClicked(GameObject objetoPulsado)
    {
        ComponenteCard componenteCard = objetoPulsado.GetComponent<ComponenteCard>();
/*

        if (componenteCard != null && componenteCard.ID == objetoObjetivoID)
        {
            MostrarMensajeGanador(); // Muestra un mensaje de victoria si el ID coincide
        }
        else
        {
            MostrarMensajePerdedor(); // Muestra un mensaje de error si el ID no coincide
        }
    }

    void MostrarMensajeGanador()
    {
        // Aquí puedes implementar la lógica para mostrar un mensaje de victoria en la mainscreen
        Debug.Log("¡Has ganado!");
        // Por ejemplo, puedes activar un panel en la mainscreen que muestre el mensaje
    }

    void MostrarMensajePerdedor()
    {
        // Aquí puedes implementar la lógica para mostrar un mensaje de error en la mainscreen
        Debug.Log("¡Has perdido!");
        // Por ejemplo, puedes mostrar un mensaje similar al de ganador pero indicando la pérdida
        
    }
    
}*/
    }
}