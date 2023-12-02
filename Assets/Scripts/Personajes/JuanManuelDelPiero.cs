using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JuanManuelDelPiero : MonoBehaviour
{
    public int id {get; set; }
    public string Nombre { get; set; }
    public bool Accesorios { get; set; }
    public int Ojos { get; set; }
    public int Pelo { get; set; }
    public bool Genero { get; set; }

        public void juanManuelDelPiero(string nombre, bool accesorios, int ojos, int pelo, bool genero)
    {
        id = 2;
        Nombre = "Juan Manuel Del Piero";
        accesorios = false;
        ojos = 1;
        pelo = 0;
        genero = false;
    }
}

