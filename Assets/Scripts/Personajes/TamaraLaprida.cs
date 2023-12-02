using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TamaraLaprida : MonoBehaviour
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Accesorios { get; set; }
    public string Ojos { get; set; }
    public string Pelo { get; set; }
    public string Genero { get; set; }

    public void tamaraLaprida(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 11;
    Nombre = "Tamara Laprida";
    accesorios = false;
    ojos = 0;
    pelo = 1;
    genero = true;
}

}
