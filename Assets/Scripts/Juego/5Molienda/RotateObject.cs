using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
	[SerializeField] private GameObject arrow;
	private float speed;

	public void SpinObjectSpeed()
    {
		speed += 20;
    }

    private void Update(){

		arrow.transform.position += transform.up * Time.deltaTime * speed;

		transform.Rotate(0f, 0f, -speed * Time.deltaTime, 0f);

		if (speed == 0)
		{
			speed -= 1;
		}
	}
}
