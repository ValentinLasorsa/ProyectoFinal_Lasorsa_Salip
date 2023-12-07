using UnityEngine;
using UnityEngine.UI;

public class MostrarMensajes : MonoBehaviour
{
    public GameObject MensajeGanador;
    public GameObject MensajePerdedor;

    public void MostrarMensajeGanador()
    {
        Debug.Log("WIN");
    }

    public void MostrarMensajePerdedor()
    {
     Debug.Log("LOST");
    }
}