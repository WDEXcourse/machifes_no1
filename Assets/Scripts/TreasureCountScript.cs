using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreasureCountScript : MonoBehaviour {

    public int treasure = 0;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnControllerColliderHit(ControllerColliderHit col){

        if(col.gameObject.tag == "Treasure")
        {
            //Instantiate(particle, col.transform.position);
            //particle.Play();
            treasure ++;
            Destroy(col.gameObject);
        }

    }
}
