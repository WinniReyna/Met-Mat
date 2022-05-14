using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnermyController : MonoBehaviour
{
	private SpriteRenderer rend;
	public static int counterNetOne;
	public static int counterNetTwo;
	public static int counterNetTree;

    void Start()
    {
	    rend = GetComponent<SpriteRenderer>();
	    
    }

	void OnMouseDown()
	{
		if (gameObject.tag == "Net1")
		{
			rend.color = new Color (1, 0, 0, 1);
			counterNetOne++;
			
			if(counterNetOne >= 3){
				rend.color = new Color (1, 1, 1, 1);
				this.gameObject.SetActive(false);
			}
		}
		if (gameObject.tag == "Net2")
		{
			rend.color = new Color (1, 0, 0, 1);
			counterNetTwo++;
			
			if(counterNetTwo >= 3){
				rend.color = new Color (1, 1, 1, 1);
				this.gameObject.SetActive(false);
			}
		}
		if (gameObject.tag == "Net3")
		{
			rend.color = new Color (1, 0, 0, 1);
			counterNetTree++;
			
			if(counterNetTree >= 3){
				rend.color = new Color (1, 1, 1, 1);
				this.gameObject.SetActive(false);
			}
		}
	}
	
	void OnMouseUp()
	{
		rend.color = new Color (1, 1, 1, 1);
	}
}
