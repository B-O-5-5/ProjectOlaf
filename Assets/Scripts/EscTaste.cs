using UnityEngine;
using System.Collections;

public class EscTaste : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
    {

        if (Input.GetKeyDown(KeyCode.Escape))
        {

            Application.LoadLevel(0);

        }

	}
}
