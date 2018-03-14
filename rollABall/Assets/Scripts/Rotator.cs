using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {

    // Use this for initialization
    // Update is called once per frame
    private Vector3 aux;
    void Start()
    {
        aux = new Vector3(15, 30, 45);
    }
    void Update () {
        transform.Rotate(aux * Time.deltaTime);
		
	}
}
