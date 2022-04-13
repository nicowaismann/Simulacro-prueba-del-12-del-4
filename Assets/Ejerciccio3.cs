using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejerciccio3 : MonoBehaviour
{

    public int monto;
    public string moneda; 

    // Start is called before the first frame update
    void Start()
    {
        if(moneda!="D" && moneda!="R" && moneda != "E")
        {
            Debug.Log("Opcion de moneda extranjera no valida");
        }

        else if (monto < 1000)
        {
            Debug.Log("El monto minimo es 1000");
        }

        switch (moneda)
        {
            case "D":
                Debug.Log(monto + " pesos argentinos son" + monto / 200 + "dolares" );
                break;

            case "R":
                Debug.Log(monto + " pesos argentinos son" + monto / 25 +  "reales");
                break;

            case "E":
                Debug.Log(monto + " pesos argentinos son" + monto / 120 + "euros");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
