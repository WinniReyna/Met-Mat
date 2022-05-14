using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Btn_Nivel : MonoBehaviour
{
	public void NivelMina()
	{
		SceneManager.LoadScene("2Mina");
	}
	
	public void NivelTraslado()
	{
		SceneManager.LoadScene("3Traslado");
	}
	
	public void NivelTrituracion()
	{
		SceneManager.LoadScene("4Trituracion");
	}
	
	public void NivelMolienda()
	{
		SceneManager.LoadScene("5Molienda");
	}
	
	public void NivelFlotacion()
	{
		SceneManager.LoadScene("6Flotacion");
	}
	
	public void NivelFusion()
	{
		SceneManager.LoadScene("7Fusion");
	}
	
	public void NivelConversion()
	{
		SceneManager.LoadScene("8Conversion");
	}
	
	public void NivelMoldeo()
	{
		SceneManager.LoadScene("9Moldeo");
	}
	
	public void NivelEnfriamiento()
	{
		SceneManager.LoadScene("10Enfriamiento");
	}
}
