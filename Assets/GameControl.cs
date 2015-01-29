using UnityEngine;
using System.Collections;

public class GameControl : MonoBehaviour {

	public enum Status {Ready, Playing, GameOver}
	public Status status = Status.Ready;
	


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	
	public void ResetGame() {
		this.status = Status.Ready;
	}
	
	public void StartGame() {
		this.status = Status.Playing;
	}
	
	public void GameOver() {
		this.status = Status.GameOver;
	}
	
}
