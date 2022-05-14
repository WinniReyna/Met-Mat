using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CinematicMovement : MonoBehaviour
{
	
	void Update(){
		StartCoroutine(DeactivateGO());
	}
	
	IEnumerator DeactivateGO(){
		yield return new WaitForSeconds(3f);
		this.gameObject.SetActive(false);
	}
}
