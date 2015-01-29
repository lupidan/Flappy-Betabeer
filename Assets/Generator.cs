using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public GameObject obstaclePrefab = null;
	
	private void CreateObstacle() {
		if (GameControl.DefaultControl.status == GameControl.Status.Playing)
			Instantiate(this.obstaclePrefab, this.transform.position, Quaternion.identity);
	}
	

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", 0.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
