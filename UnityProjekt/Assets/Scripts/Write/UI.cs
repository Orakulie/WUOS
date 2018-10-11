using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour {
    public Text BlockAuswahl;
    private string BlockAuswahlS;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        BlockAuswahlS = BlockAuswahl.text;

        if (BlockAuswahlS == "Erde")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Block").Length; i++)
            {
                GameObject.FindGameObjectsWithTag("Block")[i].GetComponent<Blöcke>().CBlock = Block.Erde;
        }
        }
        if (BlockAuswahlS == "Gras")
        {
            for (int i = 0; i < GameObject.FindGameObjectsWithTag("Block").Length; i++)
            {
                GameObject.FindGameObjectsWithTag("Block")[i].GetComponent<Blöcke>().CBlock = Block.Gras;
            }
        }
    }
}
