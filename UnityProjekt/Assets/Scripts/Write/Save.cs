using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;

public class Save : MonoBehaviour {
    public string[] split;
    public string[] String;
    public GameObject Gras;
    public GameObject Erde;
    public int count;
    public string[] array;
    public GameObject Pc;
    public Text Pc2;
    public string[] Levels;
    public int clipping;
    // Use this for initialization
    void Start () {
		
	}
	void OnGUI()
    {



        for(int i = 0;i < Levels.Length; i++)
        {
            if(GUI.Button(new Rect(10, 10 + i * 20, 100, 20), Levels[i]))
                {
                try
                {
                    for(int i3 = 0; i3 < GameObject.FindGameObjectsWithTag("Block").Length; i3++ )
                    Destroy(GameObject.FindGameObjectsWithTag("Block")[i3]);
                }catch
                {

                }


                StreamReader sr = new StreamReader(Application.dataPath + "/" + Levels[i], true);
                string line;
                count = 0;



                // Read and display lines from the file until the end of 
                // the file is reached.
                while ((line = sr.ReadLine()) != null)
                {
                    split[count] = line;
                    array = split[count].Split(',');
                    if (array[2] == "Erde")
                        Instantiate(Erde, new Vector2(float.Parse(array[0]), float.Parse(array[1])), Quaternion.identity);
                    if (array[2] == "Gras")
                        Instantiate(Gras, new Vector2(float.Parse(array[0]), float.Parse(array[1])), Quaternion.identity);

                    count++;
                }
                for (int i2 = 0; i2 < GameObject.FindGameObjectsWithTag("Block").Length; i2++)
                {
                    GameObject.FindGameObjectsWithTag("Block")[i2].GetComponent<Blöcke>().Gespawnt = true;
                }

            }

        }
    }
	// Update is called once per frame
	void Update () {
		//for(int i = 0; i < GameObject.FindGameObjectsWithTag("Block").Length; i++)
  //      {
  //          PlayerPrefs.SetFloat(GameObject.FindGameObjectsWithTag("Block")[i].gameObject.name + [i],)
  //      }
  if(Input.GetKeyDown(KeyCode.Escape))
        {
            Pc.SetActive(true);
          //  SaveAll();
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            LoadAll();
        }
    }
    public void SaveAll()
    {
        StreamWriter sw = new StreamWriter(Application.dataPath + "/" + Pc2.text+".txt", true);
        for (int i = 0; i < GameObject.FindGameObjectsWithTag("Block").Length; i++)
        {
            
            sw.WriteLine(GameObject.FindGameObjectsWithTag("Block")[i].transform.position.x + "," +GameObject.FindGameObjectsWithTag("Block")[i].transform.position.y +"," + GameObject.FindGameObjectsWithTag("Block")[i].name);
        }
        sw.Close();
    }


    void LoadAll()
    {

        DirectoryInfo dir = new DirectoryInfo(Application.dataPath + "/");
        FileInfo[] info = dir.GetFiles("*.*");
        int b = 0;
        int d = 0;
        foreach (FileInfo file in info)
        {
            // file name check

            if (file.Extension == ".txt")
            {
                d++;
                Levels = new string[d];

            }
        }
            foreach (FileInfo file in info)
        {
            // file name check

          

            // file extension check
            if (file.Extension == ".txt")
            {
               
                
               
                Levels[b] = file.Name;
                b++;

            }
           
           
        }
      


    }
}
