using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;   

public class PreguntaOjosAzules : MonoBehaviour
{
    public int Ojos;

    int ojosElegidos = 0;
    //cambiar por ojos del elegido
    int pazules = 0;

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
        Ojos = ojosElegidos;
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
                PreguntasOjosAzules();
            });
        }

    }

    

    public void PreguntasOjosAzules()
    {
            if (Ojos != pazules)
        {
            DestroyIfNotNull(BlasZanetti);
            DestroyIfNotNull(NataliaFernandez);
            DestroyIfNotNull(RobertoBanzas);
            DestroyIfNotNull(RominaSalgado);
    
        }
        else
        {
   
            DestroyIfNotNull(JuanManuelDelPiero);
           
            DestroyIfNotNull(LauraRochet);
            DestroyIfNotNull(MiguelAngelRomero);
            DestroyIfNotNull(RocioRodriguez);
            DestroyIfNotNull(RomualdoTrass);
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