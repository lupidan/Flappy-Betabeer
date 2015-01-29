using UnityEngine;
using System.Collections;

public class FlappyBetabeer : MonoBehaviour {

	public Vector2 jumpSpeed = new Vector2(0.0f,7.0f);

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
		//Rotation code
		if (GameControl.DefaultControl.status == GameControl.Status.Playing) {
			float zAngle = this.rigidbody2D.velocity.y * 10.0f;
			zAngle = Mathf.Clamp(zAngle, -45.0f, 45.0f);
			this.transform.rotation = Quaternion.Euler(0.0f,0.0f,zAngle);
		}
		
	
	}
	
	
	
	public void Jump() {
		this.rigidbody2D.velocity = this.jumpSpeed;
	}
	
	public void Reset() {
		this.transform.position = Vector3.zero;
		this.transform.rotation = Quaternion.identity;
		this.rigidbody2D.velocity = Vector2.zero;
	}
}
