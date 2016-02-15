using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GM : MonoBehaviour {

	public int grass, wood;
	public Text materials;

	// Use this for initialization
	void Start () {
		grass = 0;
		wood = 0;
	}
	
	// Update is called once per frame
	void Update () {
		// Will eventually move this out of Update() and call it only when values change 
		updateGUI();
	}

	void updateGUI() {
		materials.text = "Grass: " + grass + "\nWood: " + wood;
	}
}
