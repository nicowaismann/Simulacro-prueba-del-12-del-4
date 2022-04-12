using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio1 : MonoBehaviour

    {

    public string nombreDeAlumno;
    public int anio;
    public string orientacion;

    // Start is called before the first frame update
    void Start()
    {
        if(nombreDeAlumno.Length == 0)
        {
            Debug.Log("El nombre ingresado no es valido");
        }

        else if(anio < 1 || anio> 5)
        {
            Debug.Log("El año ingresado no es valido");
        }

        else if (anio < 3 || anio > 5)
        {
            Debug.Log("Error, aún estas en el ciclo basico");
        }

        else if(orientacion != "T" && orientacion != "D" && orientacion != "G" && orientacion!="M" && orientacion!= "H")
        {
            Debug.Log("Solo se puede ingresar T, D, G, M o H");
        }

        else
        {
            Debug.Log("Muchas gracias " + nombreDeAlumno);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
