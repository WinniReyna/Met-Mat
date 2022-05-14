using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterPepitas : MonoBehaviour
{
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "Rock")
		{
			this.transform.GetChild(0).gameObject.SetActive(true);
			StartCoroutine("DeactivateRocks");
		}
	}
	
	IEnumerator DeactivateRocks() {
		yield return new WaitForSeconds(5f);
		this.transform.GetChild(0).gameObject.SetActive(false);
		StopCoroutine("DeactivateRocks");
	}
}
