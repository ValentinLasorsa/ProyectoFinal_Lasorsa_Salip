using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntasOjosAzules : MonoBehaviour
{
    public string Pregunta1 { get; set; }
    public string Pregunta2 { get; set; }
    public string Pregunta3 { get; set; }
    public string Pregunta4 { get; set; }
    public bool Condicion;
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

    if (Condicion != false)
{
    Destroy(BlasZanetti.gameObject);
    Destroy(NataliaFernandez.gameObject);
    Destroy(RobertoBanzas.gameObject);
    Destroy(RominaSalgado.gameObject);
    // ... destroy other game objects based on your conditions
}
else
{
   
    Destroy(JuanManuelDelPiero.gameObject);
    Destroy(JuanPabloBenavidez.gameObject);
    Destroy(LauraRochet.gameObject);
    Destroy(MiguelAngelRomero.gameObject);
    Destroy(RocioRodriguez.gameObject);
    Destroy(RomualdoTrass.gameObject);
    Destroy(TamaraLaprida.gameObject);
    Destroy(ErnestoMuller.gameObject);
    // ... destroy other game objects based on your conditions
}

   // Pregunta2 = "¿Tu personaje es pelado?";
    //Pregunta3 = "¿Tu personaje tiene el pelo gris?";

    }


}