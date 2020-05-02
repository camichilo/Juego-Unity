using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InternetManager : MonoBehaviour
{
    public Text checkInternet;

    private string urlData = "http://tadeolabhack.com:8081/test/Datos/reptiliaphp/isConection.php";

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_checkInternet());
    }

    public IEnumerator _checkInternet()
    {
        //www se usa para acceder a una pagina web, retornando datos de tipo www object
        WWW getData = new WWW(urlData);
        yield return getData;

        print(getData.text);

        if (getData.text == "ConexionEstablecida")
        {
            checkInternet.text = "El usuario se conecto";
        }
        else
        {
            checkInternet.text = "Sin conexión";
        }
    }
}
