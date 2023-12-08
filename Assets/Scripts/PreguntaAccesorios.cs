using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;

public class PreguntaAccesorios : MonoBehaviour
{
    public IdPJGanador idPJGanador;
    void Start()
    {   
        Button boton = GetComponent<Button>();
        if (boton != null)
        {
            boton.onClick.AddListener(() =>
            {
                preguntaAccesorios();
            });
        }
    }

 public void preguntaAccesorios()
    {
        bool ganadorTieneAccesorios = false;
        PJ[] objetosPJ = FindObjectsOfType<PJ>();
        foreach (PJ pj in objetosPJ)
    {
        if (pj.id == idPJGanador.numeroGanador)
        {
            ganadorTieneAccesorios = (pj.Accesorios == true); // Verificar si el ganador tiene pelo rubio
            break; // Salir del bucle después de encontrar al ganador
        }
    }

    foreach (PJ pj in objetosPJ)
    {
        if (ganadorTieneAccesorios)
        {
            if (pj.Accesorios != true) // Si el ganador tiene pelo rubio, eliminar los que no lo tengan
            {  
                Destroy(pj.gameObject);
            }
        }
        else
        {
            if (pj.Accesorios == true) // Si el ganador no tiene pelo rubio, eliminar los que sí lo tengan
            {
                Destroy(pj.gameObject);
            }
        }
    }
    }
}