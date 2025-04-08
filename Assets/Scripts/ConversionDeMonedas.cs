using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConversionDeMonedas : MonoBehaviour
{

    public float  montoAconvertir;
    public string codigoMoneda;
    float cotizacionMoneda;
    float montoConvertido;

    // Start is called before the first frame update
    void Start()
    {
        if (montoAconvertir < 1000)
        {
            Debug.Log("El monto es invalido");
            return;
        }

        if (codigoMoneda == "D")
        {
            cotizacionMoneda = 1204.35f;
        } else if (codigoMoneda == "E")
        {
            cotizacionMoneda = 1541.11f;
        } else if (codigoMoneda == "R")
        {
            cotizacionMoneda = 200.1f;
        } else
        {
            Debug.Log("Opcion de moneda extranjera no valida");
            return;
        }

        montoConvertido = montoAconvertir / cotizacionMoneda;
        Debug.Log("Monto convertido = " + montoConvertido);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
