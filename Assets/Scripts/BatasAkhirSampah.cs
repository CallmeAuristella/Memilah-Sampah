using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BatasAkhirSampah : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
	void OntriggerEnter2D (Collider2D Collision)
	{
		Destroy (Collision.gameObject);
		SceneManager.LoadScene ("GameOver"); // Baris ini akan digunakan pada submodul GameOver

	}
}
