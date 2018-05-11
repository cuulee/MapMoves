﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Place : MonoBehaviour {
	public static Place currentlySelected;


	public SpriteRenderer circle;
	public SpriteRenderer icon;
	public PlaceGroup place;

	public void SetupPlace(MovesJson.SegmentsInfo.PlaceInfo placeInfo) {
		place = PlacesRanking.instance.FindPlace(placeInfo, this);
	}

	void OnMouseDown() {
		Select();
	}

	public void ChangeIconVisible(float zoom) {
		Color currentColor = circle.color;
		float alpha = 0.85f;
		if (zoom > 1) {
			icon.gameObject.SetActive(false);
			alpha = 0.5f;
		} else {
			icon.gameObject.SetActive(true);
		}
		currentColor.a = alpha;
		circle.color = currentColor;
	}

	public void Select() {
		if (currentlySelected != this) {
			RightListUI.instance.NewPlace(place);
			if (currentlySelected != null)
				currentlySelected.Deselect();
			currentlySelected = this;
			circle.color = GlobalVariables.inst.accentColor;
		}
	}

	public void Deselect() {
		circle.color = Color.white;
		currentlySelected = null;
	}
}
