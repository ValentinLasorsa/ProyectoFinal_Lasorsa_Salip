using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocioRodriguez : MonoBehaviour
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Accesorios { get; set; }
    public string Ojos { get; set; }
    public string Pelo { get; set; }
    public string Genero { get; set; }

    public void rocioRodriguez(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 8;
    Nombre = "Rocio Rodriguez";
    accesorios = false;
    ojos = 1;
    pelo = 1;
    genero = true;
}

}

