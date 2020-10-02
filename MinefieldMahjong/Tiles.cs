using System;
using System.Collections.Generic;
using System.Text;

namespace MinefieldMahjong {
	class Tiles {
		public string Type { get; protected set; }
		public Tiles() { }
		public Tiles(string type) { this.Type = type; }

	}
}
