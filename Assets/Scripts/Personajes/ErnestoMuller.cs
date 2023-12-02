using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ErnestoMuller : MonoBehaviour
{
    public int id {get; set; }
    public string Nombre { get; set; }
    public bool Accesorios { get; set; }
    public int Ojos { get; set; }
    public int Pelo { get; set; }
    public bool Genero { get; set; }

    public void ernestoMuller(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 1;
    Nombre = "Ernesto Muller";
    accesorios = false;
    ojos = 2;
    pelo = 2;
    genero = false;
}
}

