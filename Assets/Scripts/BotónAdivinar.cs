using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.SceneManagement;

public class BotónAdivinar : MonoBehaviour
{
    public IdPJGanador idPJGanador;
    public bool esperandoSeleccion = false;
    private VisualTreeAsset _visualTree;

    void Start()
    {
        _visualTree = Resources.Load<VisualTreeAsset>("UIElements/MensajePopUp");
    }

    public void ActivarSeleccion()
    {
        esperandoSeleccion = true;
    }

    public void TocarObjetoPJ(int IDPulsado, int numeroGanador)
    {
        esperandoSeleccion = false;
        Debug.Log("ESTOY EN TOCAROBJETOPJ");
       if (IDPulsado != 0)
    {
        Debug.Log(IDPulsado);
        if (IDPulsado == numeroGanador)
        {
            MostrarMensajeGanador(); // Muestra un mensaje de victoria si el ID coincide
        }
        else
        {
            MostrarMensajePerdedor(); // Muestra un mensaje de derrota si el ID no coincide
        }
    }
    else
    {
        Debug.LogError("PJ script not found on the objetoPulsado GameObject.");
    }
}

   
    private void MostrarMensajeGanador()
    {
        // Muestra un mensaje de victoria si el ID coincide
        VisualElement _popUp = _visualTree.CloneTree();
        _popUp.style.width = 400;
        _popUp.style.height = 200;
        _popUp.style.top = 100;
        _popUp.style.left = 200;
        _popUp.style.backgroundColor = Color.green;
        _popUp.style.unityTextAlign = TextAnchor.MiddleCenter;
        _popUp.Q<Label>("title").text = "¡Felicidades!";
        _popUp.Q<Label>("message").text = "Has adivinado correctamente el ID.";
        _popUp.Q<Button>("button1").text = "Reiniciar juego";
        _popUp.Q<Button>("button2").text = "Salir al menú";
        _popUp.Q<Button>("button1").clickable.clicked += () => { SceneManager.LoadScene(SceneManager.GetActiveScene().name); };
        _popUp.Q<Button>("button2").clickable.clicked += () => { SceneManager.LoadScene("MenuScene"); };
        GetComponent<UIDocument>().rootVisualElement.Add(_popUp);
    }

    private void MostrarMensajePerdedor()
    {
        // Muestra un mensaje de derrota si el ID no coincide
        VisualElement _popUp = _visualTree.CloneTree();
        _popUp.style.width = 400;
        _popUp.style.height = 200;
        _popUp.style.top = 100;
        _popUp.style.left = 200;
        _popUp.style.backgroundColor = Color.red;
        _popUp.style.unityTextAlign = TextAnchor.MiddleCenter;
        _popUp.Q<Label>("title").text = "¡Has perdido!";
        _popUp.Q<Label>("message").text = "El ID que has ingresado no coincide con el número ganador.";
        _popUp.Q<Button>("button1").text = "Reiniciar juego";
        _popUp.Q<Button>("button2").text = "Salir al menú";
        _popUp.Q<Button>("button1").clickable.clicked += () => { SceneManager.LoadScene(SceneManager.GetActiveScene().name); };
        _popUp.Q<Button>("button2").clickable.clicked += () => { SceneManager.LoadScene("MenuScene"); };
        GetComponent<UIDocument>().rootVisualElement.Add(_popUp);
    }
}
