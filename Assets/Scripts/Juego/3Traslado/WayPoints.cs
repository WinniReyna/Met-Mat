using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
	public GameObject[] wayPoints;
	int current = 0;
	float roaSpeed;
	public float speed;
	float WPradios = 1;
    
    void Update()
    {
	    if(Vector3.Distance(wayPoints[current].transform.position, transform.position) < 1){
	    	current++;
	    	if(current >= wayPoints.Length){
	    		current = 0;
	    	}
	    }
	    transform.position = Vector3.MoveTowards(transform.position, wayPoints[current].transform.position, Time.deltaTime * speed);
    }
    
	void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.tag == "PointA")
		{
			speed = 0;
			if(EnermyController.counterNetOne >= 3){
				speed = 3;
			}
			if(EnermyController.counterNetTwo >= 3){
				speed = 3;
			}
			if(EnermyController.counterNetTree >= 3){
				speed = 3;
			}
		}
		if (collision.gameObject.tag == "PointB")
		{
			this.transform.GetChild(0).gameObject.SetActive(true);
			speed = 0;
			if(EnermyController.counterNetOne >= 3){
				speed = 3;
			}
			if(EnermyController.counterNetTwo >= 3){
				speed = 3;
			}
			if(EnermyController.counterNetTree >= 3){
				speed = 3;
			}
		}
	}
    
	void OnTriggerExit2D(Collider2D collision)
	{
		speed = 3;
	}
    
}
