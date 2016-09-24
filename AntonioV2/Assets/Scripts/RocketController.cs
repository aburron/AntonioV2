using UnityEngine;
using System.Collections;

public class RocketController : MonoBehaviour {

	Rigidbody rb;
	public float forceImpulse;


	void Start () 
	{
		rb = GetComponent <Rigidbody> ();
	}
	

	void FixedUpdate () 
	{
		rb.AddForce (Vector3.up );


	}
}
