using UnityEngine;
using UnityEngine.UI;

public class MiScript : MonoBehaviour
{
    public Dropdown dropdown;

    void Start()
    {
        // Asegúrate de que la referencia al Dropdown está configurada
        if (dropdown != null)
        {
            // Añade un listener para manejar cambios en la selección
            dropdown.onValueChanged.AddListener(delegate {
                DropdownValueChanged(dropdown);
            });
        }
        else
        {
            Debug.LogError("La referencia al Dropdown no está configurada en el script.");
        }
    }

    // Manejador del evento de cambio en la selección
    void DropdownValueChanged(Dropdown dropdown)
    {
        int opcionSeleccionada = dropdown.value;
        Debug.Log("Opción seleccionada: " + dropdown.options[opcionSeleccionada].text);
    }
}