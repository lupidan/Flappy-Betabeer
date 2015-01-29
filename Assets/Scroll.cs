using UnityEngine;
using System.Collections;

public class Scroll : MonoBehaviour {

	public Vector2 scrollSpeed = Vector2.zero;
	
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (GameControl.DefaultControl.status == GameControl.Status.Playing)
			this.renderer.material.mainTextureOffset += this.scrollSpeed * Time.deltaTime;
	}
}
