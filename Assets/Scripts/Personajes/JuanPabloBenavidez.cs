using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuanPabloBenavidez : MonoBehaviour
{
    public int id {get; set; }
    public string Nombre { get; set; }
    public bool Accesorios { get; set; }
    public int Ojos { get; set; }
    public int Pelo { get; set; }
    public bool Genero { get; set; }

    public void juanPabloBenavidez(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 3;
    Nombre = "Juan Pablo Benavidez";
    accesorios = false;
    ojos = 0;
    pelo = 0;
    genero = false;
}

}

