using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menue : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


public void Write()
    {
        Application.LoadLevel("Write");
    }

    public void Play()
    {
        Application.LoadLevel("Play");
    }

    public void Exit()
    {
        Application.Quit();
    }


}
