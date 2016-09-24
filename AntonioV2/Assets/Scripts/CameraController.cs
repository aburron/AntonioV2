using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public Transform rocket;

	public Vector3 cameraPosition;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		transform.LookAt (rocket);
		this.transform.position = rocket.position + cameraPosition;
	}
}
