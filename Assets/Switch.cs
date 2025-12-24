using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class a : MonoBehaviour
{
    int DiaSemana;

    // Start is called before the first frame update
    void Start()
    {
        switch (DiaSemana)
        {
            case 1:
                debu.Log("Domingo");
                break;

            case 2:
                debug.Log("Segunda-feira");
                break;

            case 3:
                debug.Log("Terça-feira");
                break;

            case 4:
                debug.Log("Quarta-feira");
                break;

            case 5:
                debug.Log("Quinta-feira");
                break;

            case 6:
                debug.Log("Sexta-feira");
                break;

            default:
                debug.Log("Fora de data");
                break;
        }   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
