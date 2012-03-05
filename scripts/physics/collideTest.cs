using UnityEngine;
using System.Collections;
using System.IO;

public class collideTest : MonoBehaviour {
	
	growlingSpider spider;
	
	// Use this for initialization
	void Start () {
		spider = new growlingSpider();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	
    void OnTriggerEnter(Collider other) {
		if (spider.Health <= 0)
		{
			Destroy(this.gameObject);
		}
		spider.Health -= 100;
		other.transform.Translate(2,2,0,Space.Self);
		transform.Translate(0,0,10,Space.World);
		
		
    }

}
