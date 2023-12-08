using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PreguntaOjos : MonoBehaviour
{
    public IdPJGanador idPJGanador;
    public int OJOS;
    void Start()
    {   
        Button boton = GetComponent<Button>();
        if (boton != null)
        {
            boton.onClick.AddListener(() =>
            {
                Debug.Log("Botón clickeado");
                preguntaOjos();
            });
        }
    }

 public void preguntaOjos()
    {
        bool ganador = false;
        PJ[] objetosPJ = FindObjectsOfType<PJ>();
        foreach (PJ pj in objetosPJ)
    {
        if (pj.id == idPJGanador.numeroGanador)
        {
            ganador = (pj.Ojos == OJOS); // Verificar si el ganador tiene pelo rubio
            break; // Salir del bucle después de encontrar al ganador
        }
    }

    foreach (PJ pj in objetosPJ)
    {
        if (ganador)
        {
            if (pj.Ojos != OJOS) // Si el ganador tiene pelo rubio, eliminar los que no lo tengan
            {   
                Debug.Log("INTENTANDO DESTRUIR "+pj.gameObject);
                Destroy(pj.gameObject);
            }
        }
        else
        {
            if (pj.Ojos == OJOS) // Si el ganador no tiene pelo rubio, eliminar los que sí lo tengan
            {
                Debug.Log("INTENTANDO DESTRUIR "+pj.gameObject);
                Destroy(pj.gameObject);
            }
        }
    }
    }
}