using UnityEngine;
using System.Collections;
using System.IO;

public class collideTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
		//int level = playerAttributes.Instance.Level;
		//StreamWriter w = new StreamWriter("C:\\123.txt",true);
		//w.WriteLine(level);
		//w.Close();
	}
	
	// Update is called once per frame
	void Update () {
	}

	
    void OnTriggerEnter(Collider other) {
		//if (other.name == "Cube")
		//
		//Destroy(this.gameObject);
		//}
		other.transform.Translate(5,5,20,Space.Self);
    }

}
