using NUnit.Framework;
using System.Collections.Generic;

namespace Clones;

public class CloneVersionSystem : ICloneVersionSystem
{
	private List<Clone> _armyClones = new();

	public string Execute(string query)
	{
		string command = query.Split(' ')[0];
		string receiver = query.Split(' ')[1];
		string program = query.Split(' ')[2];

	}
}