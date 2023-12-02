using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntasPelo : MonoBehaviour
{
     public bool Condicion;
    public string Pregunta1 { get; set; }
    public string Pregunta2 { get; set; }
    public string Pregunta3 { get; set; }
    public string Pregunta4 { get; set; }
    public PJ BlasZanetti;
    public PJ ErnestoMuller;
    public PJ JuanManuelDelPiero;
    public PJ JuanPabloBenavidez;
    public PJ LauraRochet;
    public PJ MiguelAngelRomero;
    public PJ NataliaFernandez;
    public PJ RobertoBanzas;
    public PJ RocioRodriguez;
    public PJ RominaSalgado;
    public PJ RomualdoTrass;
    public PJ TamaraLaprida;
    void Start()
    {
      BlasZanetti = GameObject.Find("BlasZanetti").GetComponent<PJ>();
    ErnestoMuller = GameObject.Find("ErnestoMuller").GetComponent<PJ>();
    JuanManuelDelPiero = GameObject.Find("JuanManuelDelPiero").GetComponent<PJ>();
    JuanPabloBenavidez = GameObject.Find("JuanPabloBenavidez").GetComponent<PJ>();
    LauraRochet = GameObject.Find("LauraRochet").GetComponent<PJ>();
    MiguelAngelRomero = GameObject.Find("MiguelAngelRomero").GetComponent<PJ>();
    NataliaFernandez = GameObject.Find("NataliaFernandez").GetComponent<PJ>();
    RobertoBanzas = GameObject.Find("RobertoBanzas").GetComponent<PJ>();
    RocioRodriguez = GameObject.Find("RocioRodriguez").GetComponent<PJ>();
    RominaSalgado = GameObject.Find("RominaSalgado").GetComponent<PJ>();
    RomualdoTrass = GameObject.Find("RomualdoTrass").GetComponent<PJ>();
    TamaraLaprida = GameObject.Find("TamaraLaprida").GetComponent<PJ>();

    }

 public void PreguntasPeloDescarte(string Pregunta1, string Pregunta2, string Pregunta3)
{
    //Pregunta1 = "¿Tu personaje tiene el pelo rubio?";
   if (Condicion != true)
{
    Destroy(BlasZanetti.gameObject);
    Destroy(ErnestoMuller.gameObject);
    Destroy(LauraRochet.gameObject);
    // ... destroy other game objects based on your conditions
}
else
{
    Destroy(JuanManuelDelPiero.gameObject);
    Destroy(JuanPabloBenavidez.gameObject);
    Destroy(MiguelAngelRomero.gameObject);
    Destroy(NataliaFernandez.gameObject);
    Destroy(RobertoBanzas.gameObject);
    Destroy(RocioRodriguez.gameObject);
    Destroy(RominaSalgado.gameObject);
    Destroy(RomualdoTrass.gameObject);
    Destroy(TamaraLaprida.gameObject);
    // ... destroy other game objects in the 'else' block
}

   // Pregunta2 = "¿Tu personaje es pelado?";
    //Pregunta3 = "¿Tu personaje tiene el pelo gris?";
}

public void PreguntasOjos(string Pregunta1, string Pregunta2, string Pregunta3)
{
   // Pregunta1 = "¿Sus ojos son de color marrón?";
    //Pregunta2 = "¿Sus ojos son de color celeste?";
    //Pregunta3 = "¿Sus ojos son de color negro?";
   // Pregunta4 = "¿Sus ojos son de color verde?";
}

public void PreguntasGenero(string Pregunta1, string Pregunta2)
{
    //Pregunta1 = "¿Tu personaje es mujer?";
    //Pregunta2 = "¿Tu personaje es hombre?";
}

public void PreguntasAccesorios(string Pregunta1)
{
    //Pregunta1 = "¿Tu personaje tiene anteojos?";
}
}



    
