using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Calculadora : MonoBehaviour
{
    public ToggleGroup TG;
    

    void Start()
    {
        if(TG == null) TG = GetComponent<ToggleGroup>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Seleccion();
    }

    public string Seleccion()
    {
        string selec;
        Toggle selectedToggle = TG.ActiveToggles().FirstOrDefault();
       return selec = selectedToggle.name;
    }


}
