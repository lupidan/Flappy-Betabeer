using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour {

	public Vector3 movingSpeed = new Vector3(-3.0f, 0.0f, 0.0f);
	
	
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.DefaultControl.status == GameControl.Status.Playing)
			this.rigidbody2D.velocity = this.movingSpeed;
		else
			this.rigidbody2D.velocity = Vector2.zero;
			
		if (this.transform.position.x < -10.0f)
			Destroy(this.gameObject);
	}
	
	//Called when a collision is first detected
	void OnCollisionEnter2D(Collision2D collision2D) {
		FlappyBetabeer flappyBetabeer = collision2D.gameObject.GetComponent<FlappyBetabeer>();
		if (flappyBetabeer != null) {
			GameControl.DefaultControl.GameOver();
		}
	}
}
