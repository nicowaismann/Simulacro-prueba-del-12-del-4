using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio2 : MonoBehaviour
{


    public string categoría;
    public int días;
   


    // Start is called before the first frame update
    void Start()
    {
        int comidaGato = días * 300;
        int comidaPerro = días * 400;
        int comidaPerroGrande = días * 700;

        if (categoría != "G" && categoría != "PP" && categoría != "PG" || días < 3)
        {
            Debug.Log("Error");
        }

        switch (categoría)
        {
            case "G":
                Debug.Log("Para ese período se necesitan " + comidaGato + "gramos de alimento y el costo sería de $" + comidaGato*80/100);
                    break;

            case "PP":
                Debug.Log("Para ese período se necesitan " + comidaPerro + "gramos de alimento y el costo sería de $" + comidaPerro*80/100);
                    break;

            case "PG":
                Debug.Log("Para ese período se necesitan " + comidaPerroGrande + "gramos de alimento y el costo sería de $" + comidaPerroGrande*80/100);
                    break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
