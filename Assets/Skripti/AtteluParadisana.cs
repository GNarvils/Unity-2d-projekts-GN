using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AtteluParadisana : MonoBehaviour {
	public GameObject bean;
	public GameObject teddy;
	public GameObject car;
	public GameObject aunt;
	public GameObject attels;
	public Sprite[] attelumasivs;
	public GameObject slideris;

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
	public void izskritosais(int skaitlis){
		if (skaitlis == 0) {
			attels.GetComponent<Image> ().sprite = attelumasivs [0];
		} else if (skaitlis == 1) {
			attels.GetComponent<Image> ().sprite = attelumasivs [1];
		} else if (skaitlis == 2) {
			attels.GetComponent<Image> ().sprite = attelumasivs [2];
		}
	}
	public void mainitLielumu(){
		float pasreizejaVertiba = slideris.GetComponent<Slider> ().value;
		attels.transform.localScale = new Vector2 (1F*pasreizejaVertiba, 1F*pasreizejaVertiba);
	}
}
