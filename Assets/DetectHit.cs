using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DetectHit : MonoBehaviour {
	public Slider healthbar;
	//  	
	void OnTriggerEnter(Collider other) {
		healthbar.value -= 20;
		//Debug.Log ("Hit");
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
