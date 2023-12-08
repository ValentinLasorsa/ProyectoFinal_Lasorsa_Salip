using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class PreguntasGenero : MonoBehaviour
{
    public IdPJGanador idPJGanador;
    public bool GENERO;
    void Start()
    {   
        Button boton = GetComponent<Button>();
        if (boton != null)
        {
            boton.onClick.AddListener(() =>
            {
                preguntaGenero();
            });
        }
    }

 public void preguntaGenero()
    {
        bool ganador = false;
        PJ[] objetosPJ = FindObjectsOfType<PJ>();
        foreach (PJ pj in objetosPJ)
    {
        if (pj.id == idPJGanador.numeroGanador)
        {
            ganador = (pj.Genero == GENERO); // Verificar si el ganador tiene pelo rubio
            break; // Salir del bucle después de encontrar al ganador
        }
    }

    foreach (PJ pj in objetosPJ)
    {
        if (ganador)
        {
            if (pj.Genero != GENERO) // Si el ganador tiene pelo rubio, eliminar los que no lo tengan
            {   
                Destroy(pj.gameObject);
            }
        }
        else
        {
            if (pj.Genero == GENERO) // Si el ganador no tiene pelo rubio, eliminar los que sí lo tengan
            {
                Destroy(pj.gameObject);
            }
        }
    }
    }
}