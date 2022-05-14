using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndMinaLevel : MonoBehaviour
{
	private int rockCouncerGame = 0;
	
	void Update(){
		if(rockCouncerGame >= 10){
			Debug.Log("End Game");
		}
	}
	
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Rock")
		{
			rockCouncerGame++;
		}
	}
}
