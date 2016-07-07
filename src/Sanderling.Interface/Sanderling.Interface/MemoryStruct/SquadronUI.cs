using System.Collections.Generic;

namespace Sanderling.Interface.MemoryStruct
{
	public interface SquadronsUI
	{
		IEnumerable<SquadronUI> SetSquadron { get; }

		IUIElement LaunchAllButton { get; }

		IUIElement OpenBayButton { get; }

		IUIElement RecallAllButton { get; }
	}

	public interface SquadronUI
	{
		int? SquadronNumber { get; }

		SquadronHealth Health { get; }

		IEnumerable<SquadronAbility> SetAbility { get; }
	}

	public interface SquadronHealth
	{
		int? SquadronSizeMax { get; }

		int? SquadronSizeCurrent { get; }
	}

	public interface SquadronAbility : IUIElement
	{
		int? Quantity { get; }
	}
}
