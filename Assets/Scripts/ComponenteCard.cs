using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComponenteCard : MonoBehaviour
{
    // Método para seleccionar o deseleccionar la tarjeta
    public void Seleccionar()
    {
        // Agrega aquí la lógica para seleccionar la tarjeta
        Debug.Log("Tarjeta seleccionada: " + gameObject.name);
        // Ejemplo: gameObject.SetActive(!gameObject.activeSelf); para alternar la visibilidad
    }
}

