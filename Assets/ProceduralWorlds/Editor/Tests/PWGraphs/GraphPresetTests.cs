﻿using UnityEngine;
using UnityEditor;
using UnityEngine.TestTools;
using NUnit.Framework;
using System.Collections;
using System.Linq;
using ProceduralWorlds.Core;
using ProceduralWorlds.Node;

namespace ProceduralWorlds.Tests.Graphs
{
	public class BaseGraphPresetTests
	{

		static string worldGraphPresetPath = "GraphPresets/World/Full";
		// string biomeGraphPresetPath = "GraphPresets/Biome";
	
		[Test]
		public static void WorldGraphPresets()
		{
			TextAsset[] worldGraphPresets = Resources.LoadAll< TextAsset >(worldGraphPresetPath);

			foreach (var worldGraphPreset in worldGraphPresets)
			{
				string[] commands = worldGraphPreset.text.Split('\n');

				var graph = BaseGraphBuilder.NewGraph< WorldGraph >()
					.ImportCommands(commands)
					.Execute()
					.GetGraph();

				graph.UpdateComputeOrder();
				
				//TODO: process the graph and check output

				// Assert.That(graph.GetOutput< FinalTerrain >() != null)
			}
		}
		
		/* 
		[Test]
		public void BiomeGraphPresets()
		{
			TextAsset[] biomeGraphPresets = Resources.LoadAll< TextAsset >(biomeGraphPresetPath);

			//TODO: generate a previewGraph for all the biomes here
			//generate the biome graph in the preview
			//assign each biomeGraph to the cerated biome node
			//assign the previewGraph to each biomeGraph
			//Process()

			foreach (var biomeGraphPreset in biomeGraphPresets)
			{
				string[] commands = biomeGraphPreset.text.Split('\n');

				var graph = BaseGraphBuilder.NewGraph< BiomeGraph >()
					.ImportCommands(commands)
					.Custom((g) => {
						(g.inputNode as NodeBiomeGraphInput).previewGraph = previewgraph;
					})
					.Execute()
					.GetGraph();
				
				//TODO: process the graph and check output
			}
		}
		*/
	}
}