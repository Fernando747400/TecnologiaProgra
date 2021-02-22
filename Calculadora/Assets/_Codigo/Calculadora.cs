using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using UnityEngine.Events;

public class Calculadora : MonoBehaviour
{
    public ToggleGroup TG;
    InputField inp1, inp2;
    Text resultado;
    double num1, num2, res;

    // Start is called before the first frame update
    void Start()
    {
        inp1 = GetComponent<InputField>();
        inp2 = GetComponent<InputField>();
        resultado = GetComponent<Text>();
        if(TG == null) TG = GetComponent<ToggleGroup>();
    }

    // Update is called once per frame
    void Update()
    {
        Seleccion();
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

    public string Seleccion()
    {
        string selec;
        Toggle selectedToggle = TG.ActiveToggles().FirstOrDefault();
       return selec = selectedToggle.name;
    }

}
