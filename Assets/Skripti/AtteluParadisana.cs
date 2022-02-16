using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject bean;
	public GameObject teddy;
	public GameObject car;
	public GameObject aunt;

	public void paradiBean(bool vertiba){
		bean.SetActive (vertiba);
	}
	public void paradiTeddy(bool vertiba){
		teddy.SetActive (vertiba);
	}
	public void paradiCar(bool vertiba){
		car.SetActive (vertiba);
	}
	public void paradiAunt(bool vertiba){
		aunt.SetActive (vertiba);
	}
	public void kreisi(){
		bean.transform.localScale = new Vector2 (1, 1);
	}
	public void labi(){
		bean.transform.localScale = new Vector2 (-1, 1);
	}
}
