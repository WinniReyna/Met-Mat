using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorRiel : MonoBehaviour
{
	public GameObject contenedor;
	public GameObject[] contenedorArray;
	
	public enum GameState {Inicio, Playing};
	public GameState gameState = GameState.Inicio;
	
	public float velocity = 5.0f;
	int contadorRiel = 0;
	int numeroSelector;
	
	float tamRiel;
	
	public GameObject rielAnterior;
	public GameObject rielNuevo;
	
    // Start is called before the first frame update
    void Start()
    {
	    contenedor = GameObject.Find("ContenedorRiel");
    }
	
	void PosicionarInicio()
	{
		if(rielAnterior.transform.position.x <= -10)
		{
			rielNuevo = rielAnterior;
			rielAnterior.transform.position = new Vector3(40,-3.4f,0);
			rielAnterior = rielNuevo;
		}
	}
	
	void BuscoRiel()
	{
		contenedorArray = GameObject.FindGameObjectsWithTag("Riel");
		for(int i=0; i < contenedorArray.Length;i++)
		{
			contenedorArray[i].gameObject.transform.parent = contenedor.transform;
			contenedorArray[i].gameObject.SetActive(false);
			contenedorArray[i].gameObject.name = "RielOff_"+ i;
		}
		//CrearRiel();
	}
	
	void CrearRiel()
	{
		contadorRiel++;
		numeroSelector = 0;
		GameObject riel = Instantiate(contenedorArray[numeroSelector]);
		//riel.SetActive(true);
		//riel.name = "Riel"+contadorRiel;
		//riel.transform.parent = gameObject.transform;
		//Posicion();
	}
	
	void Posicion()
	{
		rielAnterior = GameObject.Find("Riel"+(contadorRiel - 1));
		rielNuevo = GameObject.Find("Riel"+ contadorRiel);
		
		rielNuevo.transform.position = new Vector3(rielAnterior.transform.position.x,
			rielAnterior.transform.position.y, 0);
	}
	
    // Update is called once per frame
    void Update()
    {
	    if(gameState == GameState.Inicio && (Input.GetKeyDown("up")))
	    {
		    gameState = GameState.Playing;
	    }
	    else if(gameState == GameState.Playing)
	    {
	    	
		    transform.Translate(Vector3.left * velocity * Time.deltaTime);
		    PosicionarInicio();
	    }
    }
}
