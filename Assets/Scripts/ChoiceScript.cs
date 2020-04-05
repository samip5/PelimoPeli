using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChoiceScript : MonoBehaviour {

     public GameObject TextBox;
	 public GameObject Choice01;
	 public GameObject Choice02;
	 public GameObject Choice03;
	 public GameObject Choice04;
	 public int ChoiceMade;
	 
	 
	 public void ChoiceOption1 () {
	     TextBox.GetComponent<Text>().text = "Valinta 1";
	     ChoiceMade = 1;
	 }
	 
	 public void ChoiceOption2 () {
	     TextBox.GetComponent<Text>().text = "Valinta 2";
	     ChoiceMade = 2;
	 }
	 
	 public void ChoiceOption3 () {
	     TextBox.GetComponent<Text>().text = "Valinta 3";
	     ChoiceMade = 3;
	 }
	 
	 public void ChoiceOption4 () {
	     TextBox.GetComponent<Text>().text = "Valinta 4";
	     ChoiceMade = 4;
	 }
	 
	 void Update () {
	     if (ChoiceMade >= 1) {
		     Choice01.SetActive (false);
			 Choice02.SetActive (false);
			 Choice03.SetActive (false);
			 Choice04.SetActive (false);
        }
    }
}