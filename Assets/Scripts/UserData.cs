using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UserData : MonoBehaviour
{
    private string getUrlEscribir = "http://tadeolabhack.com:8081/test/Datos/reptiliaphp/escribir.php";

    public int IdUser = 300;
    private string nombre = "";
    private string apellido = "";
    private string apodo = "";
    private int edad = 0;

    public InputField campoNombre;
    public InputField campoApellido;
    public InputField campoApodo;
    public InputField campoEdad;

    public void SenData()
    {
        StartCoroutine(enviarDatosUsuario());
    }

    private IEnumerator enviarDatosUsuario()
    {
        nombre = campoNombre.text;
        apellido = campoApellido.text;
        apodo = campoApodo.text;

        if (campoEdad.text != "")
        {
            edad = int.Parse(campoEdad.text);
        }
        else
        {
            print("El campo de edad no puede estar vacio");
        }
        
        print(IdUser + " " + nombre + " " + apellido + " " + apodo + " " + edad);

        if (nombre == "" || apellido == "" || edad == 0)
        {
            print("los campos de nombre, apellido y edad deben tener información");
        }
        else
        {
            WWWForm form = new WWWForm();
            form.AddField("identificacion", IdUser);
            form.AddField("nom", nombre);
            form.AddField("ape", apellido);
            form.AddField("apo", apodo);
            form.AddField("ed", edad);

            WWW retroalimentacion = new WWW(getUrlEscribir, form);
            yield return retroalimentacion;

            print(retroalimentacion.text);
        }
    }
}
