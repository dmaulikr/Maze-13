﻿using UnityEngine;
using System.Collections;

public class MainPanelController : PanelController {

	[SerializeField]private GameObject ShareBtn;
	[SerializeField]private GameObject MarketBtn;

	void Awake(){
		GBEventListener.Get(ShareBtn).onClick = ShowSharePanel;
		GBEventListener.Get(MarketBtn).onClick = ShowMarketBtnPanel;
	}

	void Start () {
	
	}
	
	void Update () {
	
	}

	void ShowSharePanel(GameObject obj){
		
	}

	void ShowMarketBtnPanel(GameObject obj){
		DialogTool.ShowOneBtnDialog (this.transform, "a", "b", DialogHitType.Exit, test);
//		DialogTool.ShowTwoBtnDialog (this.transform, "a", "b", DialogHitType.Exit, null, test);
	}

	void test(DialogHitType type){
		Debug.Log ("test--"+type);
	}
}
