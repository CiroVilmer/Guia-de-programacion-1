using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ej09 : MonoBehaviour
{
    /*Realizá un programa que resuelva el siguiente problema:  
Tres personas aportan diferente capital a una sociedad. Se desea saber qué porcentaje del  total aportó cada una (indicando nombre y porcentaje) y cuál es el monto del total aportado  por las tres.  
Ingresar por Inspector el ingreso del capital aportado por cada una de las personas y luego  mostrar lo pedido en el siguiente formato:  
Nombre: capital aportado: $ … , Porcentaje del capital: %.... , Monto total aportado: $ …. 
*/
    public string Nom_per1;
    public float Ap_per1;
    public string Nom_per2;
    public float Ap_per2;
    public string Nom_per3;
    public float Ap_per3;

    float total_acc;
    float porcentaje;
    
    // Start is called before the first frame update
    void Start()
    {
        total_acc = Ap_per1 + Ap_per2 + Ap_per3;

        porcentaje = Ap_per1 * 100 / total_acc;

        Debug.Log("Nombre: "+ Nom_per1 + ", Capital aportado: $" + Ap_per1 + ", Porcentaje del capital: %"+porcentaje+", Monto total aportado= $" + total_acc);

        porcentaje = Ap_per2 * 100 / total_acc;

        Debug.Log("Nombre: " + Nom_per2 + ", Capital aportado: $" + Ap_per2 + ", Porcentaje del capital: %" + porcentaje + ", Monto total aportado = $" + total_acc);

        porcentaje = Ap_per3 * 100 / total_acc;

        Debug.Log("Nombre: " + Nom_per3 + ", Capital aportado: $" + Ap_per3 + ", Porcentaje del capital: %" + porcentaje + ", Monto total aportado= $" + total_acc);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
