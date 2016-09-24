using UnityEngine;
using System.Collections;

public class ButtonManager : MonoBehaviour {


	public Transform point;
	public Camera mainCamera;
	public Vector3 cameraPosition;
	public float minLerp;
	public float maxLerp;
	public float timeLerp;
	public float xPos;
	public float yPos;
	public float zPos;

	void Start ()
	{
		transform.LookAt (point);
	}

	public void PlayButton ()
	{
		Application.LoadLevel (0);
	}

	public void TitleButton ()
	{
		Application.LoadLevel (1);
	}





	public CameraTitle ct;

	public void ShopButon ()
	{	
		//ct.transform.LookAt (target);
		//mainCamera.transform.position = cameraPosition;
		this.transform.position = cameraPosition;
		cameraPosition = new Vector3 (Mathf.Lerp (minLerp, maxLerp, timeLerp),xPos,yPos);

	}
}
