using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Counter : MonoBehaviour
{
	public static int rockCounter;
	
	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Rock")
		{
			Destroy(col.gameObject);
			rockCounter++;
		}
	}
}