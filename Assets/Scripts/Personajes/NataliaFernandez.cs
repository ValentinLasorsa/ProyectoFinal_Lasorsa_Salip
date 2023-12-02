using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NataliaFernandez : MonoBehaviour
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Accesorios { get; set; }
    public string Ojos { get; set; }
    public string Pelo { get; set; }
    public string Genero { get; set; }

    public void nataliaFernandez(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 6;
    Nombre = "Natalia Fernandez";
    accesorios = true;
    ojos = 3;
    pelo = 3;
    genero = true;
}

}

