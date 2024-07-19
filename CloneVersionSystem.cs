using NUnit.Framework;
using System.Collections.Generic;

namespace Clones;

public class CloneVersionSystem : ICloneVersionSystem
{
	private Dictionary<int, Clone> _armyClones = new();
	private const int _firstCloneID = 1;

	public CloneVersionSystem()
	{
		_armyClones.Add(_firstCloneID, new Clone());
	}

	public void CreateNewClone(int key)
	{
		var clone = _armyClones[key];
		int newClonesID = key + 1;
		_armyClones.Add(newClonesID, new Clone(clone.GetLearnedPrograms(), clone.GetRollBackPrograms()));
	}

	public string Execute(string query)
	{
		var request = new Request(query);
		switch (request.Command)
		{
			case CommandTypes.Learn:
                _armyClones[request.Receiver].Learn(request.Program);
                break;
			case CommandTypes.Relearn:
				_armyClones[request.Receiver].Relearn();
				break;
			case CommandTypes.Rollback:
				_armyClones[request.Receiver].RollBack();
				break;
			case CommandTypes.Check:
				return _armyClones[request.Receiver].Check();
			case CommandTypes.Clone:
				CreateNewClone(request.Receiver);
				break;
			default:
				return null;
		}
		return null;
	}
}