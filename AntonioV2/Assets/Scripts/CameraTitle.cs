using UnityEngine;
using System.Collections;

public class CameraTitle : MonoBehaviour {

	public Transform point;
	public float angle;

	void Start () {
	
	}
	

	void Update () 
	{
		transform.LookAt (point);
		transform.RotateAround (point.transform.position, Vector3.up, angle);
	}
}
