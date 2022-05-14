using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPrefabs : MonoBehaviour
{
	public Transform SpawnPoint;
	public GameObject[] rocks;
	public float x, y;
	
	void Start()
	{
		Instantiate(rocks[Random.Range(0, rocks.Length)], SpawnPoint.position, Quaternion.identity, SpawnPoint.transform);
	}
	
	void Update(){
		if(this.transform.position.x <= 2.23f){
			this.transform.position = new Vector2(x, y);
			Destroy(this.transform.GetChild(0).gameObject);
		}
		if(transform.childCount == 0){
			Instantiate(rocks[Random.Range(0, rocks.Length)], SpawnPoint.position, Quaternion.identity, SpawnPoint.transform);
		}
	}
}
