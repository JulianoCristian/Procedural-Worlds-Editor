﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

namespace PW
{
	public class PWNodeTexture2D : PWNode {

		[PWOutput("tex2D")]
		public Texture2D		outputTexture;

		public override void OnNodeCreate()
		{
			externalName = "Texture 2D";
		}

		public override void OnNodeGUI()
		{
			GUILayout.Space(EditorGUIUtility.singleLineHeight);
			PreviewRenderUtility d = new PreviewRenderUtility();
			outputTexture = EditorGUILayout.ObjectField(outputTexture, typeof(Texture2D), false) as Texture2D;
			if (outputTexture != null)
				PWGUI.TexturePreview(outputTexture);
		}

		//no process needed
	}
}