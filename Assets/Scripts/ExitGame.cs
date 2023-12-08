using UnityEngine;

public class ExitGame : MonoBehaviour
{
    public void Salir()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false; // Sale del modo de reproducción en el Editor
        #else
            Application.Quit(); // Sale de la aplicación en un build
        #endif
    }
}
