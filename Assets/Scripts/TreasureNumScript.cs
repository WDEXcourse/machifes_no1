﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TreasureNumScript : MonoBehaviour {

    public TreasureCountScript tcSctipt;
    public GameObject player;
    private int treasure;
    private Text treasureNum;

    // Use this for initialization
    void Start() {
        treasureNum = GetComponentInChildren<Text>();
        player = GameObject.Find("Player");
        tcSctipt = player.GetComponent<TreasureCountScript>();
    }
	
	// Update is called once per frame
	void Update () {
        treasure = tcSctipt.treasure;
        Debug.Log(treasure);
        treasureNum.text = treasure.ToString();
    }
}
