using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControladorNavegacion : MonoBehaviour
{
	public void volver(){
		SceneManager.LoadScene(0);
	}
	public void jugar(){
		SceneManager.LoadScene(1);
	}
	public void multijugador(){
		SceneManager.LoadScene(0);
	}
	public void salir(){
		Application.Quit();
	}
}
