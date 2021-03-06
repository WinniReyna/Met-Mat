using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CorrutinaBlockActiveTree : MonoBehaviour
{
	void Start(){
		this.GetComponent<Collider2D>().enabled = true;
	}
	
	void Update(){
		if(EnermyController.counterNetTree >= 3){
			StartCoroutine("ActivateColliderWithNet");
		}
	}

	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Car")
		{
			StartCoroutine("ActivateCollider");
		}
	}
    
    
	IEnumerator ActivateCollider() {
		yield return new WaitForSeconds(Random.Range(1, 3));
		this.GetComponent<Collider2D>().enabled = false;
		yield return new WaitForSeconds(.6f);
		this.GetComponent<Collider2D>().enabled = true;
		EnermyController.counterNetTree = 0;
		
		StopCoroutine("ActivateCollider");
	}
	
	IEnumerator ActivateColliderWithNet() {
		this.GetComponent<Collider2D>().enabled = false;
		yield return new WaitForSeconds(.6f);
		this.GetComponent<Collider2D>().enabled = true;
		EnermyController.counterNetTree = 0;
		
		StopCoroutine("ActivateCollider");
	}
}
