﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PanelController : MonoBehaviour {

	protected DialogTwoBtnController dialogTwoBtn;

	public void SetActive(bool isActive){
		this.gameObject.SetActive (isActive);
		if (isActive) {
			DefaultPanelController.isCouldViewTurn = false;
		} else {
			DefaultPanelController.isCouldViewTurn = true;

			if ("SettingPanel".Equals (name)) {
				SettingInfo.Instance.Save ();
			}
		}
	}

	public void ShowDialog(string title, string content, DialogHitType hitType){
		if (dialogTwoBtn == null) {
			dialogTwoBtn = this.transform.parent.FindChild("DialogTwoBtn").gameObject.GetComponent<DialogTwoBtnController>() as DialogTwoBtnController;
		}
		dialogTwoBtn.InitContent (title, content, hitType);
		dialogTwoBtn.confirmBtnClicked = DialogConfirmBtnClicked;
		dialogTwoBtn.SetActive (true);
	}

	public virtual void DialogConfirmBtnClicked(DialogHitType type){
		Debug.Log ("DialogConfirmBtnClicked:"+type);
	}
}