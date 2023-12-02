using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RomualdoTrass : MonoBehaviour
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Accesorios { get; set; }
    public string Ojos { get; set; }
    public string Pelo { get; set; }
    public string Genero { get; set; }

    public void romualdoTrass(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 10;
    Nombre = "Romualdo Trass";
    accesorios = true;
    ojos = 2;
    pelo = 2;
    genero = false;
}

}

