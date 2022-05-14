using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
	public GameObject panelPausa;
	public GameObject panelInstrucciones;
	
	public void PausaCanvas()
	{
		panelPausa.SetActive(true);
	}
	
	public void RegresarJuego()
	{
		panelPausa.SetActive(false);
	}
	
	public void Instrucciones()
	{
		panelInstrucciones.SetActive(true);
	}
	
	public void RegresarPausa()
	{
		panelInstrucciones.SetActive(false);
	}
	
	public void Salir()
	{
		SceneManager.LoadScene("1Pantalla");
	}
}
