using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class administradorNiveles : MonoBehaviour {

    public int Pantalla = 0;

	public void irAjuego()
	{
		
		SceneManager.LoadScene(Pantalla);
	}

	public void CerrarApp()
	{
		
		Application.Quit();
	}
}
