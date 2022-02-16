using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TekstaParadisana : MonoBehaviour {	
    //Uzglabā tekstu, kurš paņemts no input lauka
	public string teksts;
	//Lauks no kura es tekstu paņemšu
	public GameObject ievadeslauks;
	//Teksta objekts, kur attēlot mainīgā teksts saturu
	public GameObject tekstaAttelosanasLauks;
	public void darbibasArTekstu(){
		teksts = ievadeslauks.GetComponent<Text> ().text;
		tekstaAttelosanasLauks.GetComponent<Text>().text = "Sveiks "+teksts.ToUpper()+"!";
	}
		
}
