using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlasZanetti : MonoBehaviour
{
    public int id {get; set; }
    public string Nombre { get; set; }
    public bool Accesorios { get; set; }
    public int Ojos { get; set; }
    public int Pelo { get; set; }
    public bool Genero { get; set; }

    public void blasZanetti(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 0;
    Nombre = "Blas Zanetti";
    accesorios = true;
    ojos = 3;
    pelo = 2;
    genero = false;
}
}

