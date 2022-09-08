using UnityEngine;
using System.Collections;

public class CameraMovement : MonoBehaviour {
	public float moveSpeed;
	public GameObject target;

	private Transform rigTransform;

	// Use this for initialization
	void Start() {rigTransform = this.transform.parent;
		
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if(target == null){
			return;
		}

		rigTransform.position = Vector3.Lerp(rigTransform.position, target.transform.position, 
			Time.deltaTime * moveSpeed);
	}

}
