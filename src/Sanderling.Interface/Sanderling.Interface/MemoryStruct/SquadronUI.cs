using System.Collections.Generic;

namespace Sanderling.Interface.MemoryStruct
{
	public interface ISquadronsUI
	{
		IEnumerable<ISquadronUI> SetSquadron { get; }

		IUIElement LaunchAllButton { get; }

		IUIElement OpenBayButton { get; }

		IUIElement RecallAllButton { get; }
	}

	public interface ISquadronUI
	{
		int? SquadronNumber { get; }

		ISquadronHealth Health { get; }

		IEnumerable<ISquadronAbility> SetAbility { get; }
	}

	public interface ISquadronHealth
	{
		int? SquadronSizeMax { get; }

		int? SquadronSizeCurrent { get; }
	}

	public interface ISquadronAbility : IUIElement
	{
		int? Quantity { get; }
	}
}
