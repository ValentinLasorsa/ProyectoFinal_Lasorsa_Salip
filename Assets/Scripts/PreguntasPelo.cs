using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PreguntasPelo : MonoBehaviour
{
    public IdPJGanador idPJGanador;
    public int PELO;
    void Start()
    {   
        Button boton = GetComponent<Button>();
        if (boton != null)
        {
            boton.onClick.AddListener(() =>
            {
                PreguntaPelo();
            });
        }
    }

 public void PreguntaPelo()
    {
        bool ganador = false;
        PJ[] objetosPJ = FindObjectsOfType<PJ>();
        foreach (PJ pj in objetosPJ)
    {
        if (pj.id == idPJGanador.numeroGanador)
        {
            ganador = (pj.Pelo == PELO); // Verificar si el ganador tiene pelo rubio
            break; // Salir del bucle después de encontrar al ganador
        }
    }

    foreach (PJ pj in objetosPJ)
    {
        if (ganador)
        {
            if (pj.Pelo != PELO) // Si el ganador tiene pelo rubio, eliminar los que no lo tengan
            {   
                Destroy(pj.gameObject);
            }
        }
        else
        {
            if (pj.Pelo == PELO) // Si el ganador no tiene pelo rubio, eliminar los que sí lo tengan
            {
                Destroy(pj.gameObject);
            }
        }
    }
    }
}