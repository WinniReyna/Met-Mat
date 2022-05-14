using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimCar : MonoBehaviour
{
	public GameObject[] rock;
	
	void Start(){
		rock[0].SetActive(false);
		rock[1].SetActive(false);
		rock[2].SetActive(false);
		rock[3].SetActive(false);
		rock[4].SetActive(false);
		rock[5].SetActive(false);
		
	}

    void Update()
    {
	    if(Counter.rockCounter == 3){
	    	rock[0].SetActive(true);
	    }
	    if(Counter.rockCounter == 5){
	    	rock[1].SetActive(true);
	    }
	    if(Counter.rockCounter == 10){
	    	rock[2].SetActive(true);
	    }if(Counter.rockCounter == 15){
	    	rock[3].SetActive(true);
	    }
	    if(Counter.rockCounter == 20){
	    	rock[4].SetActive(true);
	    }
	    if(Counter.rockCounter == 25){
	    	rock[5].SetActive(true);
	    }
	    if(Counter.rockCounter >= 30){
	    	rock[6].SetActive(true);
	    }
    }
}
