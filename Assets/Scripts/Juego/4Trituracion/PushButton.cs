using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PushButton : MonoBehaviour
{
	public GameObject[] deactivateRocks;
	private int counterRocks;
	
	public GameObject pepita;
	
	void Update(){
		if(counterRocks == 4){
			deactivateRocks[0].SetActive(false);
			deactivateRocks[1].SetActive(true);
		}
		if(counterRocks == 8){
			deactivateRocks[1].SetActive(false);
		}
	}
	
	public void DropRocks()
	{
		counterRocks++;
		pepita.SetActive(true);
		StartCoroutine("DeactivateRocks");
	}
	
	IEnumerator DeactivateRocks() {
		yield return new WaitForSeconds(.45f);
		pepita.SetActive(false);
		StopCoroutine("DeactivateRocks");
	}
}
