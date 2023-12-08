using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  

public class PreguntaAccesorios : MonoBehaviour
{
    public int id;
    public string Nombre;
    public bool Accesorios;
    public int Ojos;
    public int Pelo;
    public bool Genero;
    public int JGanador;
    public IdPJGanador idPJGanador;
    public IdPJGanador pj;
    
    public BlasZanetti BlasZanetti;
    public ErnestoMuller ErnestoMuller;
    public JuanManuelDelPiero JuanManuelDelPiero;
    public LauraRochet LauraRochet;
    public MiguelAngelRomero MiguelAngelRomero;
    public NataliaFernandez NataliaFernandez;
    public RobertoBanzas RobertoBanzas;
    public RocioRodriguez RocioRodriguez;
    public RominaSalgado RominaSalgado;
    public RomualdoTrass RomualdoTrass;
    public TamaraLaprida TamaraLaprida;
    
    void Start()
    {
        Accesorios = true;
        //modificar despues
        BlasZanetti = GameObject.Find("Blas Zanetti").GetComponent<BlasZanetti>();
        ErnestoMuller = GameObject.Find("Ernesto Muller").GetComponent<ErnestoMuller>();
        JuanManuelDelPiero = GameObject.Find("Juan Manuel Del Piero").GetComponent<JuanManuelDelPiero>();
        LauraRochet = GameObject.Find("Laura Rochet").GetComponent<LauraRochet>();
        MiguelAngelRomero = GameObject.Find("Miguel Angel Romero").GetComponent<MiguelAngelRomero>();
        NataliaFernandez = GameObject.Find("Natalia Fernandez").GetComponent<NataliaFernandez>();
        RobertoBanzas = GameObject.Find("Roberto Banzas").GetComponent<RobertoBanzas>();
        RocioRodriguez = GameObject.Find("Rocio Rodriguez").GetComponent<RocioRodriguez>();
        RominaSalgado = GameObject.Find("Romina Salgado").GetComponent<RominaSalgado>();
        RomualdoTrass = GameObject.Find("Romualdo Trass").GetComponent<RomualdoTrass>();
        TamaraLaprida = GameObject.Find("Tamara Laprida").GetComponent<TamaraLaprida>();

        Button boton = GetComponent<Button>();
            if (boton != null)
            {
                boton.onClick.AddListener(() =>
            {
                Debug.Log("Botón clickeado");
                PreguntasAccesorios();
            });
        }
    }

public int CompararPersonajeGanador()
{
    if(BlasZanetti.id == IdPJGanador.numeroGanador)
    {    
        Debug.Log("ID del PJ: "+BlasZanetti.id);
        Debug.Log("Nombre del PJ: "+BlasZanetti.Nombre);
        Debug.Log("Accesorios del PJ: "+BlasZanetti.Accesorios);
        Debug.Log("Ojos del PJ: "+BlasZanetti.Ojos);
        Debug.Log("Pelo del PJ: "+BlasZanetti.Pelo);
        Debug.Log("Genero del PJ: "+BlasZanetti.Genero);
    }
    return IdPJGanador.numeroGanador;
}

public void PreguntasAccesorios()
{
   if (Accesorios != true)
{
      DestroyIfNotNull(BlasZanetti);
      DestroyIfNotNull(NataliaFernandez);
      DestroyIfNotNull(RobertoBanzas);
      DestroyIfNotNull(RominaSalgado);
      DestroyIfNotNull(RomualdoTrass);
      DestroyIfNotNull(LauraRochet);
}
else
{
      DestroyIfNotNull(JuanManuelDelPiero);
      DestroyIfNotNull(MiguelAngelRomero);
      DestroyIfNotNull(RocioRodriguez);
      DestroyIfNotNull(TamaraLaprida);
      DestroyIfNotNull(ErnestoMuller);
}
}

private void DestroyIfNotNull(MonoBehaviour obj)
    {
        if (obj != null)
        {
            Destroy(obj.gameObject);
        }
    }

}