using UnityEngine;
using System.Collections;

public class PlaySound : MonoBehaviour {

    public AudioSource sound01;

	// Use this for initialization
	void Start () {
        sound01 = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    public void PlaySE()
    {
        sound01.Play();
    }
}
