
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {


	
	// Update is called once per frame
	void Update () {
		
		float eixoX = Input.GetAxis("Horizontal");
		float eixoZ = Input.GetAxis("Vertical");
		
		Vector3 direcao = new Vector3(eixoX,0, eixoZ);

	}
}
