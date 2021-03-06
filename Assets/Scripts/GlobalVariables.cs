﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GlobalVariables : MonoBehaviour {
	public static GlobalVariables inst;

	public Sprite[] icons;
	public Color accentColor;
	public Color disabledColor;
	public bool firstWeekMonday = true;
	[HideInInspector]
	public bool mapControls = true;

	void Awake() {
		inst = this;
	}

	public void MouseEnter() {
		mapControls = true;
	}

	public void MouseExit() {
		mapControls = false;
	}

	public void SetIcon(MovesJson.SegmentsInfo.PlaceInfo place, SpriteRenderer image) {
		LoadIcon(place, (int sprite) => image.sprite = PlacesRanking.instance.categories[sprite].smallIcon);
	}
	public void SetIcon(MovesJson.SegmentsInfo.PlaceInfo place, Image image) {
		LoadIcon(place, (int sprite) => image.sprite = PlacesRanking.instance.categories[sprite].smallIcon);
	}
	public void SetIcon(MovesJson.SegmentsInfo.PlaceInfo place, Action<int> action) {
		LoadIcon(place, (int sprite) => action.Invoke(sprite));
	}
	void LoadIcon(MovesJson.SegmentsInfo.PlaceInfo place, Action<int> action) {
		PlaceType placeType = place.type;
		if (placeType == PlaceType.home)
			action.Invoke(4);
		else if (placeType == PlaceType.school)
			action.Invoke(9);
		else
			action.Invoke(6);

		int? customIcon = PlacesSave.FindIcon(place.id);
		if (customIcon != null) {
			action.Invoke(customIcon.Value);
		}
		
	}

	public Vector3 TransformToCenter(Vector3 position) {
		Vector3 newPos = position;
		newPos.x += 160 * (3.555f / Screen.width) * RenderMap.instance.mapScale;
		newPos.y += 34 * (3.555f / Screen.width) * RenderMap.instance.mapScale;
		return newPos;
	}
	public void MoveCamera(Vector3 position) {
		Vector3 cameraPos = position;
		cameraPos.z = -40;
		cameraPos.x -= 160 * (3.555f / Screen.width) * RenderMap.instance.mapScale;
		cameraPos.y -= 34 * (3.555f / Screen.width) * RenderMap.instance.mapScale;
		Camera.main.transform.position = cameraPos;
	}
}
