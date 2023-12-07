using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    public GameObject canva;
    public void ReiniciarEscena()
    {
        Debug.Log("Reiniciando...");
        // Carga la escena actual utilizando su índice en el Build Settings
        int escenaActual = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(1);
        canva.SetActive(false);
    }
}
