using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;   

public class PreguntaMujer : MonoBehaviour
{
    public int id;
    public string Nombre;
    public bool Accesorios;
    public int Ojos;
    public int Pelo;
    public bool Genero;
    
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
    Genero = false;
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
                PreguntaGeneroMujer();
            });
        }

    }

 public void PreguntaGeneroMujer()
{
   if (Genero != true)
{
      DestroyIfNotNull(RocioRodriguez);
      DestroyIfNotNull(TamaraLaprida);
      DestroyIfNotNull(LauraRochet);
      DestroyIfNotNull(RominaSalgado);
      DestroyIfNotNull(NataliaFernandez);
}
else
{
      DestroyIfNotNull(BlasZanetti);
      DestroyIfNotNull(ErnestoMuller);
      DestroyIfNotNull(RobertoBanzas);
      DestroyIfNotNull(RomualdoTrass);
      DestroyIfNotNull(JuanManuelDelPiero);
      DestroyIfNotNull(MiguelAngelRomero);
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
