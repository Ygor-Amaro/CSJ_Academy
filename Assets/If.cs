using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class If : MonoBehaviour
{
    public int n1;
    public int n2;

    public bool Valor;

    // Start is called before the first frame update
    void Start()
    {
        // Debug.Log(Valor);
        // Debug.Log(n1 + " " + n2);

        if (n1 > 0)
        {
            Debug.Log("Número é positivo");
        }
        else if (n1 < 0)
        {
            Debug.Log("O número é negativo");
        }
        else
        {
            Debug.Log("O número é zero");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
