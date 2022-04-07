using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelOpener : MonoBehaviour
{
	public GameObject Panel; //panel i'm going to open
	
	public void OpenPanel(){
		
		if (Panel != null) { //if there is a panel
		
			bool isActive = Panel.activeSelf;
			Panel.SetActive(!isActive);
		}
	}
}
