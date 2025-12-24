using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // tipos de variáveis C# para o Unity
    public int ValoInteiro = 10;
    private int VarInt = 5;

    int NumeroInteiro = 3; // variável inteira
    float NumeroDecimal = 3.0f; // variável decimal
    string Texto = "Hello World"; // variável texto
    bool VerdadeiroFalso = true; // variável booleana

    // Declarando variáveis do Unity
    public GameObject MeuObjeto; // variável para armazenar um objeto do Unity
    public Transform MinhaTransformacao; // variável para armazenar a transformação de um objeto


    void Start()
    {
        MeuObjeto = gameObject;
    }   
}
