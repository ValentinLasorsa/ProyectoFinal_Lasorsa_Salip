using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PreguntasPelo : MonoBehaviour
{//condicion necesita conseguir el valor a partir de el Pj Que se elije random
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

    }
    
    void Update()
    {
        PreguntasPeloDescarte();
        
    }

    void OnClick()
    {
        Condicion = true;
    }
    private void PreguntasPeloDescarte()
    {
        if (Condicion != true)
        {

            Destroy(BlasZanetti.gameObject);
            Destroy(ErnestoMuller.gameObject);
            Destroy(LauraRochet.gameObject);
  
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
    
        }
    }

    
}


    
