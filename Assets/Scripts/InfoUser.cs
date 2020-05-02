using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfoUser : MonoBehaviour
{
    private string UrlPosition = "http://tadeolabhack.com:8081/test/Datos/MostrarPosXusuario.php";

    public Text TextPuesto;
    public int idUser = 50;

    public void obtenerPuesto()
    {
        StartCoroutine(datos());
    }

    public IEnumerator datos()
    {
   
        string info = UrlPosition + "?IDuser=50" + idUser;

        WWW resultInfo = new WWW(info);
        yield return resultInfo;

        print(resultInfo.text);

        TextPuesto.text = resultInfo.text;
    }
}
