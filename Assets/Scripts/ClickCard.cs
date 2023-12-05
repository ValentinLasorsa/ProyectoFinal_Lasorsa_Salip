using UnityEngine;
using UnityEngine.EventSystems;

public class ClickCard : MonoBehaviour, IPointerClickHandler
{
    public BotónAdivinar botónAdivinar;
    public PJ pj;
    public IdPJGanador idPJGanador;
 
    public void OnPointerClick(PointerEventData eventData)
    {
        if (botónAdivinar.esperandoSeleccion == true) 
        {
        // Imprime el nombre del objeto al que se hizo clic en la consola
        Debug.Log("Hiciste clic en: " + pj.Nombre);
        botónAdivinar.TocarObjetoPJ(pj.id,idPJGanador.numeroGanador);
        // Aquí puedes agregar el código que se ejecutará cuando se haga clic en el objeto
        }
        else{
            Debug.Log("Tenés que tocar el Botón primero!!");
        }
         }
}