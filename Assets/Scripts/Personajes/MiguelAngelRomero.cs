using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MiguelAngelRomero : MonoBehaviour
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Accesorios { get; set; }
    public string Ojos { get; set; }
    public string Pelo { get; set; }
    public string Genero { get; set; }

    public void miguelAngelRomero(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 5;
    Nombre = "Miguel Angel Romero";
    accesorios = false;
    ojos = 2;
    pelo = 1;
    genero = false;
}

}

