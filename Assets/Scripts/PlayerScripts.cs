using UnityEngine;

public class PlayerScripts : MonoBehaviour {

	private float PlayerSpped = 0.06f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.W)) {
			transform.Translate (0, 0, PlayerSpped);
		}
		if(Input.GetKey(KeyCode.A)){
			transform.Translate (-PlayerSpped, 0, 0);
			}
		if (Input.GetKey (KeyCode.S)) {
			transform.Translate (0, 0, -PlayerSpped);
		}
		if (Input.GetKey (KeyCode.D)) {
			transform.Translate (PlayerSpped, 0, 0);
		}
	}
}
