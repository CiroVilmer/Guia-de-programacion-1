using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej03 : MonoBehaviour
{
    /* 3. Crear una variable pública que permita ingresar texto. Permitir que al ejecutar el programa
    se muestre en la consola un mensaje de saludo que incluya el texto de la variable. Por
    ejemplo, si en la variable se ingresa el texto “Ana”, el mensaje en consola debe decir “Hola
    Ana”.*/

    public string nombre;

    // Start is called before the first frame update
    void Start()
    {
        if (nombre == "Ana")
        {
            Debug.Log("Hola Ana");

        }
        else
        {
            Debug.Log("Buenos dias " + nombre);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
