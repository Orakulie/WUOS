using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KI : MonoBehaviour {
    public Vector3 Ziel;
    public float Speed;
    public GameObject[] Array;
    public int Next;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Array = new GameObject[GameObject.FindGameObjectsWithTag("Block").Length];
        Array = GameObject.FindGameObjectsWithTag("Block");
        Ziel.z = 0;
        transform.LookAt(Ziel);
        transform.position += transform.forward * Speed *Time.deltaTime;
        
        Ziel = Array[Next-1].transform.position;
       
        if(Vector3.Distance(Array[Next-1].transform.position, transform.position) < 0.01f)
        {

            if (Array.Length > Next)
            {
                Speed = 1;
                Next++;
            }else
            {
                Speed = 0;
            }
           
        }
	}
}
