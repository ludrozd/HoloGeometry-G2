using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonTextChange : MonoBehaviour
{
	public Text text;
	public Font newFont;
	public Font oldFont;
	private int x = 1;

	
	public void ChangeFont(){
		if (x == 1){
			text.font = newFont;
			x = 0;
		} else {
			text.font = oldFont;
			x = 1;
		}
		
	}
	
	public void ChangeFontSize(){
		if (x == 1){
			text.fontSize = 35;
			x = 0;
		} else {
			text.fontSize = 28;
			x = 1;
		}
	}
}
