using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobertoBanzas : MonoBehaviour
{
    public int id {get; set; }
    public string Nombre { get; set; }
    public bool Accesorios { get; set; }
    public int Ojos { get; set; }
    public int Pelo { get; set; }
    public bool Genero { get; set; }

    public void robertoBanzas(string nombre, bool accesorios, int ojos, int pelo, bool genero)
{
    id = 7;
    Nombre = "Roberto Banzas";
    accesorios = true;
    ojos = 3;
    pelo = 3;
    genero = false;
}

}

