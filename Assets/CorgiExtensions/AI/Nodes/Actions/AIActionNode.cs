﻿using MoreMountains.Tools;
using UnityEngine;

namespace TheBitCave.CorgiExensions.AI
{
	/// <summary>
	/// A node representing a single Corgi <see cref="MoreMountains.Tools.AIAction"/>.
	/// </summary>
	[NodeWidth(250)]
	[CreateNodeMenu("")]
	public class AIActionNode : AINode
	{

		/// <summary>
		/// The Corgi Action label.
		/// </summary>
		public string label;

		[Output(connectionType = ConnectionType.Multiple)] public ActionConnection output;
		
		/// <summary>
		/// Adds the corresponding <see cref="MoreMountains.Tools.AIAction"/> component to the gameObject.
		/// </summary>
		/// <param name="go">The gameObject that should have the action attached.</param>
		/// <returns></returns>
		public virtual AIAction AddActionComponent(GameObject go)
		{
			throw new System.NotImplementedException();
		}

		/// <summary>
		/// Checks if abilities used by the <see cref="MoreMountains.Tools.AIAction"/> is
		/// attached to the gameObject.
		/// </summary>
		/// <returns></returns>
		public virtual bool ValidateAbilityDependencies()
		{
			return true;
		}
	}
}

