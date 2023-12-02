using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RominaSalgado : MonoBehaviour
{
    public int id { get; set; }
    public string Nombre { get; set; }
    public string Accesorios { get; set; }
    public string Ojos { get; set; }
    public string Pelo { get; set; }
    public string Genero { get; set; }

    public void rominaSalgado(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 9;
    Nombre = "Romina Salgado";
    accesorios = true;
    ojos = 3;
    pelo = 1;
    genero = true;
}

}

