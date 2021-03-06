﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScriptGameController : MonoBehaviour {

    public Text textDistanceSunPlayer;

    GameObject player;
    GameObject sun;

    public Vector3 distSunPlayer;

    void Start()
    {
        player = GameObject.Find("Player");
        sun = GameObject.Find("Sun");
    }

	// Update is called once per frame
	void Update () {
        distSunPlayer = new Vector3(
            sun.transform.position.x - player.transform.position.x,
            sun.transform.position.y - player.transform.position.y,
            sun.transform.position.z - player.transform.position.z);
        

        textDistanceSunPlayer.text = "Sun Distance:" + distSunPlayer.magnitude.ToString("N2");
	}
}
