using UnityEngine;
using UnityEngine.UI;

public class MostrarMensajes : MonoBehaviour
{
    public GameObject miCanvas;

    // Función para activar la visibilidad del Canvas
    public void ActivarCanvas()
    {
        miCanvas.SetActive(true); // Esto activará la visibilidad del Canvas
    }
}