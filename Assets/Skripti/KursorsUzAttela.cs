using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KursorsUzAttela : MonoBehaviour {
	public AudioSource skanasAvots;
	public AudioClip skanaKoAtskenot;
	public void  uzbiditsUzAttela(){
		skanasAvots.PlayOneShot (skanaKoAtskenot);
	}
	public void  nobiditsUzAttela(){
		skanasAvots.Stop ();
	}
}
