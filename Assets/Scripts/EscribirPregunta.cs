using UnityEngine;
using UnityEngine.UI;

public class MostrarTextoEnPantalla : MonoBehaviour
{
    public Text textoEnPantalla; 

    public void MostrarTexto()
    {
       
        textoEnPantalla.text = "¡Texto que aparece en pantalla!";
    }
}