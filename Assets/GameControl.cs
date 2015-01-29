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
		TimeControl();
		
		if (DidInput())
			ManageInput();
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
	
	private void TimeControl() {
		//Handle time scale
		switch(this.status) {
			
			case Status.Ready:
				Time.timeScale = 0.0f;
				break;
				
			case Status.Playing:
			case Status.GameOver:
				Time.timeScale = 1.0f;
				break;
			
		}
	}
	
	private bool DidInput() {
		//Return true if input was detected
		return (Input.GetKeyDown(KeyCode.Space));
	}
	
	private void ManageInput() {
		
		switch(this.status) {
			
			case Status.Ready:
				StartGame();
				break;
				
			case Status.Playing:
				//JUMP
				break;
				
			case Status.GameOver:
				ResetGame();
				break;
			
		}
	}
	
}
