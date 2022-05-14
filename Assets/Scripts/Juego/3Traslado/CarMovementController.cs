using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovementController : MonoBehaviour
{
	public int yPos;
	public float timeWait;
	private bool forwardOne = false;
	private bool forwardRandomOne = true;
	
    void Update()
	{
		
		//moverse adelante y atras cuando piques 3 veces la red
		if(EnermyController.counterNetOne >= 3 && forwardOne == false){
			this.transform.position += new Vector3(-10 * Time.deltaTime , 0, 0);
			if(this.transform.position.x <= -24.77f){
				this.transform.position = new Vector3(-24.77f , yPos, 0);
				this.transform.GetChild(0).gameObject.SetActive(true);
				StartCoroutine("WaitAndMoveBack");
			}
		}
		
		if(forwardOne == true){
			this.transform.position += new Vector3(10 * Time.deltaTime , 0, 0);
			if(this.transform.position.x >= -4.08f){
				this.transform.position = new Vector3(-4.08f , yPos, 0);
				EnermyController.counterNetOne = 0;
				StartCoroutine("WaitAndMoveForward");
			}
		}
		////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
		//moverse aunque no hayas desecho la red
		
		if(EnermyController.counterNetOne >= 0 && EnermyController.counterNetOne < 3 && forwardRandomOne == false){
			this.transform.GetChild(1).gameObject.SetActive(true);
			this.transform.position += new Vector3(-10 * Time.deltaTime , 0, 0);
			if(this.transform.position.x <= -24.77f){
				this.transform.position = new Vector3(-24.77f , yPos, 0);
				this.transform.GetChild(0).gameObject.SetActive(true);
				EnermyController.counterNetOne = 0;
				StartCoroutine("RandomMovementBack");
			}
		}
		if(EnermyController.counterNetOne == 0f && forwardRandomOne == true ){
			this.transform.GetChild(1).gameObject.SetActive(false);
			this.transform.position += new Vector3(10 * Time.deltaTime , 0, 0);
			if(this.transform.position.x >= -4.08f){
				this.transform.position = new Vector3(-4.08f , yPos, 0);
				EnermyController.counterNetOne = 0;
				StartCoroutine("RandomMovementForward");
			}
		}
		///////////////////////////////////////////////////////////////////////////////////////////////////////////////
	}
	
	IEnumerator WaitAndMoveBack()
	{
		StopCoroutine("WaitAndMoveForward");
		yield return new WaitForSeconds(5f);
		forwardOne = true;
	}
	
	IEnumerator WaitAndMoveForward()
	{
		StopCoroutine("WaitAndmoveBack");
		yield return new WaitForSeconds(5f);
		forwardOne = false;
	}
	
	IEnumerator RandomMovementBack()
	{
		StopCoroutine("RandomMovementForward");
		yield return new WaitForSeconds(5f);
		forwardRandomOne = true;
	}
	
	IEnumerator RandomMovementForward()
	{
		StopCoroutine("RandomMovementBack");
		yield return new WaitForSeconds(5f);
		forwardRandomOne = false;
	}
}
