using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mouse : MonoBehaviour {
    public Vector3 mousepos;
    public GameObject Sprite;
    public GameObject Sp;
    public float Distance = 100000;
    public bool[] Rdy;
    public GameObject[] Array;
	// Use this for initialization
	void Start () {
        Instantiate(Sprite);
        Sp = GameObject.FindGameObjectWithTag("Sprite");
	}
	
	// Update is called once per frame
	void Update () {
        Rdy = new bool[GameObject.FindGameObjectsWithTag("Block").Length];
        Array = new GameObject[GameObject.FindGameObjectsWithTag("Block").Length];
        Array = GameObject.FindGameObjectsWithTag("Block");

       mousepos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousepos.z = 0;
        Sp.transform.position = mousepos;
     if(Input.GetMouseButton(0))
        {
          
            for(int i = 0; i < Array.Length; i++)
            {
                //if(Vector3.Distance(Array[i].transform.position, Sp.transform.position )< Distance)
                //    {
                //    Distance = Vector3.Distance(Array[i].transform.position, Sp.transform.position);
                //}
                Debug.Log(Vector3.Distance(Array[i].transform.position, Sp.transform.position));
                if (Vector3.Distance(Array[i].transform.position, Sp.transform.position) > Distance )
                {
                    Rdy[i] = true;
                }
                

            }
            if(Check()== true)
            {
                Sp.gameObject.tag = "Block";
                Sp.gameObject.name = "Block " + GameObject.FindGameObjectsWithTag("Block").Length;
                Instantiate(Sprite);
                Sp = GameObject.FindGameObjectWithTag("Sprite");
            }


            
        }
	}


    private bool Check()
    {
        for(int i = 0; i < Rdy.Length; i++)
        {
            if(Rdy[i] == false)
            {
                return false;
            }

        }
        return true;
    }
}
