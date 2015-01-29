using UnityEngine;
using System.Collections;

public class Generator : MonoBehaviour {

	public GameObject obstaclePrefab = null;
	
	private void CreateObstacle() {
		Vector3 randomFactor = new Vector3(0.0f, Random.Range(2.0f,-2.0f), 0.0f);
		if (GameControl.DefaultControl.status == GameControl.Status.Playing)
			Instantiate(this.obstaclePrefab, this.transform.position + randomFactor, Quaternion.identity);
	}
	

	// Use this for initialization
	void Start () {
		InvokeRepeating("CreateObstacle", 0.0f, 2.0f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
