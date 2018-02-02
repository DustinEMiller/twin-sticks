using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        print("H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
        print("V: " + CrossPlatformInputManager.GetAxis("Vertical"));
    }
}
