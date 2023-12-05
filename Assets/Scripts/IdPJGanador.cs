using UnityEngine;

public class IdPJGanador : MonoBehaviour
{
    public int numeroGanador; // Declaración de la variable que almacenará el número ganador

    void Start()
    {
        GenerarIDGanador(); // Llama a la función GenerarIDGanador() cuando el juego comienza
    }

    int GenerarIDGanador()
    {
        numeroGanador = Random.Range(1, 13); // Genera un número aleatorio entre 1 y 100 (inclusive)
        // Encuentra todos los objetos de tipo PJ en la escena
        PJ[] objetosPJ = FindObjectsOfType<PJ>();
        // Recorre la lista de objetos PJ y compara el valor de la variable id con el valor de la variable numeroGanador
        foreach (PJ pj in objetosPJ)
        {
            if (pj.id == numeroGanador)
            {
                Debug.Log("ID del PJ: "+pj.id);
                Debug.Log("Nombre del PJ: "+pj.Nombre);
                Debug.Log("Accesorios del PJ: "+pj.Accesorios);
                Debug.Log("Ojos del PJ: "+pj.Ojos);
                Debug.Log("Pelo del PJ: "+pj.Pelo);
                Debug.Log("Genero del PJ: "+pj.Genero);
            }
        }
        return numeroGanador;
    }
}
