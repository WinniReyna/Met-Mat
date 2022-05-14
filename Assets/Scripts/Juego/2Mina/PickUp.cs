using UnityEngine;

[RequireComponent(typeof(Collider2D))]

public class PickUp : MonoBehaviour
{
	private Camera mainCamera;
	private float CameraZDistance;
	
	[SerializeField]
	private Transform gap;
	private Vector2 initialPosition;
	
	void Start(){
		mainCamera = Camera.main;
		CameraZDistance = mainCamera.WorldToScreenPoint(transform.position).z;
	}
	
	void Update(){
		initialPosition = gap.transform.position;
	}
	
	void OnMouseDrag(){
		Vector3 ScreenPosition = 
			new Vector3(Input.mousePosition.x, Input.mousePosition.y, CameraZDistance);
			
		Vector3 NewWorldPosition =
			mainCamera.ScreenToWorldPoint(ScreenPosition);
		transform.position = NewWorldPosition;
	}
	
	void OnMouseUp(){
		this.transform.position = new Vector2(gap.position.x, gap.position.y);
	}
}
