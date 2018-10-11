using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public enum Block { Erde, Gras };
public class Blöcke : MonoBehaviour {
    public Block CBlock;
    public int BlockID;
    public GameObject Gras;
    public GameObject Erde;
    private GameObject Spawn;
    public bool Gespawnt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        

        switch(CBlock)
        {
            case Block.Gras:
                {
                    Spawn = Gras;
                    break;
                }
            case Block.Erde:
                {
                    Spawn = Erde;
                    break;
                }
            default:
                {
                    Spawn = Erde;
                    break;
                }

        }
        if(Input.GetKeyDown(KeyCode.D) && Gespawnt == false)
        {
            Instantiate(Spawn, new Vector3(transform.position.x + 0.8f, transform.position.y), Quaternion.identity).gameObject.name = Spawn.name;
            Gespawnt = true;
        }
        if (Input.GetKeyDown(KeyCode.A) && Gespawnt == false)
        {
            Instantiate(Spawn, new Vector3(transform.position.x - 0.8f, transform.position.y), Quaternion.identity).gameObject.name = Spawn.name;
            Gespawnt = true;
        }
        if (Input.GetKeyDown(KeyCode.W) && Gespawnt == false)
        {
            Instantiate(Spawn, new Vector3(transform.position.x, transform.position.y+ 0.8f), Quaternion.identity).gameObject.name = Spawn.name;
            Gespawnt = true;
        }
        if (Input.GetKeyDown(KeyCode.S) && Gespawnt == false)
        {
            Instantiate(Spawn, new Vector3(transform.position.x, transform.position.y - 0.8f), Quaternion.identity).gameObject.name = Spawn.name;
            Gespawnt = true;
        }


    }
    
}
