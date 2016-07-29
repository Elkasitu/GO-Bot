using PokemonGo.RocketAPI;
using System;
using PokemonGo.RocketAPI.Enums;
using AllEnum;
using System.Collections.Generic;

namespace GO_Bot.Internals {

	internal class GoSettings : ISettings {

		public AuthType AuthType { get; set; } = AuthType.Google;

		public double DefaultAltitude
        {
			get
            {
				return 17;
			}
		}

        // Coordinates for Central Park, NY, USA
		public double DefaultLatitude { get; set; } = 40.7828687;
		public double DefaultLongitude { get; set; } = -73.9675438;
		public string GoogleRefreshToken { get; set; } = String.Empty;

		public ICollection<KeyValuePair<ItemId, int>> itemRecycleFilter {
			get {
				return new List<KeyValuePair<ItemId, int>>();
			}

			set {
				throw new NotImplementedException();
			}
		}

		public string PtcPassword { get; set; } = String.Empty;
		public string PtcUsername { get; set; } = String.Empty;
        public string GglPassword { get; set; } = String.Empty;
        public string GglUsername { get; set; } = String.Empty;


	}

}
