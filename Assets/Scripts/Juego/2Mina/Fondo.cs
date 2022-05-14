using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fondo : MonoBehaviour
{
	[Range(0f, 0.20f)]
	public float parallaxSpeed_b = 0.02f;
	public  RawImage background;
	
	[Range(0f, 0.20f)]
	public float parallaxSpeed_r = 0.02f;
	public  RawImage riel;
	
	[Range(0f, 0.20f)]
	public float parallaxSpeed_c1 = 0.02f;
	public  RawImage cueva1;
	
	[Range(0f, 0.20f)]
	public float parallaxSpeed_c8 = 0.02f;
	public  RawImage cueva8;
	
	[Range(0f, 0.20f)]
	public float parallaxSpeed_c9 = 0.02f;
	public  RawImage cueva9;
	
	[Range(0f, 0.20f)]
	public float parallaxSpeed_c10 = 0.02f;
	public  RawImage cueva10;
	
	public enum GameState {Inicio, Playing};
	public GameState gameState = GameState.Inicio;
	
  
    void Update()
    {
	    if(gameState == GameState.Inicio && (Input.GetKeyDown("up")))
	    {
	    	gameState = GameState.Playing;
	    }
	    else if(gameState == GameState.Playing)
	    {
	    	float finalSpeed = parallaxSpeed_b * Time.deltaTime;
	    	background.uvRect = new Rect(background.uvRect.x + parallaxSpeed_b * Time.deltaTime, 0f, 1f, 1f);
	    	riel.uvRect = new Rect(riel.uvRect.x + parallaxSpeed_r * Time.deltaTime, 0f, 1f, 1f);
	        cueva1.uvRect = new Rect(cueva1.uvRect.x + parallaxSpeed_c1 * Time.deltaTime, 0f, 1f, 1f);
	    	cueva8.uvRect = new Rect(cueva8.uvRect.x + parallaxSpeed_c8 * Time.deltaTime, 0f, 1f, 1f);
	    	cueva9.uvRect = new Rect(cueva9.uvRect.x + parallaxSpeed_c9 * Time.deltaTime, 0f, 1f, 1f);
	    	cueva10.uvRect = new Rect(cueva10.uvRect.x + parallaxSpeed_c10 * Time.deltaTime, 0f, 1f, 1f);
	    }
    }
}
