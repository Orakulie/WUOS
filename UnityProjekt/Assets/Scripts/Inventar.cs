using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventar : MonoBehaviour {
    public List<Item> inventory = new List<Item>();
    private Database data;
	// Use this for initialization
	void Start () {
        data = GameObject.FindGameObjectWithTag("Data").GetComponent<Database>();
        inventory.Add(data.Items[0]);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
