using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LauraRochet : MonoBehaviour
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Accesorios { get; set; }
    public string Ojos { get; set; }
    public string Pelo { get; set; }
    public string Genero { get; set; }

    public void lauraRochet(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 4;
    Nombre = "Laura Rochet";
    accesorios = true;
    ojos = 1;
    pelo = 2;
    genero = true;
}

}

