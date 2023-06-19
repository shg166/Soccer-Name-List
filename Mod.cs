using System;
using System.Reflection;
using UnityEngine;
using ColossalFramework.UI;
using ICities;

namespace JP_SoccerNameList
{
	public class JP_SoccerNameList : IUserMod
	{

		public string Name
		{
			get { return "JP Soccer Name List (CNL) v1.0"; }
		}

		public string Description
		{
			get { return "Custom Name Listsを使って、DLC Mtach Dayの対戦相手のチーム名を変更します"; }
		}

	}
}

