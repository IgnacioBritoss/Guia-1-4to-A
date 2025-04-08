using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nada : MonoBehaviour
{
    public string nombre;
    public int año;
    public string orientacion;



    // Start is called before the first frame update
    void Start()
    {
        if (año > 5 || año < 0)
        {
            Debug.Log("dentro de 1 ; 5");
            return;
        }
        
        if (nombre == "")
        {
            Debug.Log("pone algo");
            return;
        }

        if (orientacion != "T" || orientacion != "D" || orientacion != "G" || orientacion != "M" || orientacion != "H")
        {
            Debug.Log("“Solo puede ingresar T, D, G, M o H”");
            return;
        }

        if (año < 3)
        {
            Debug.Log("sos chico");
        }

        if (año < 5 || año > 0 && (nombre != "") && (orientacion == "T" || orientacion == "D" || orientacion == "G" || orientacion == "M" || orientacion == "H"))
        {
            Debug.Log("gracias");
        }


        

    }



    // Update is called once per frame
    void Update()
    {
        
    }
}
