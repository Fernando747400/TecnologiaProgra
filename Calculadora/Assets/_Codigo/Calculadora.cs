using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Calculadora : MonoBehaviour
{
    InputField inp1, inp2;
    Text resultado;
    double num1, num2, res;

    // Start is called before the first frame update
    void Start()
    {
        inp1 = GetComponent<InputField>();
        inp2 = GetComponent<InputField>();
        resultado = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void calculo()
    {
        switch (Seleccion())
        {
            case '+':
                res = num1 + num2;
                break;

            case '-':
                res = num1 - num2;
                break;
            case '*':
                res = num1 * num2;
                break;
            case '/':
                if (num2 != 0)
                {
                    res = num1 / num2;
                }
                
                break;

        }
    }
}
