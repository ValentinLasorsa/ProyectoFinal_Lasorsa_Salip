using UnityEngine;

public class GenerarNumeroAleatorio : MonoBehaviour
{
    private void Start()
    {
        int numeroAleatorio = Random.Range(1, 13);
        Debug.Log("Número aleatorio entre 1 y 12: " + numeroAleatorio);
    }
}