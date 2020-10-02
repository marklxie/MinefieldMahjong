using System;
using System.Collections.Generic;
using System.Text;

namespace MinefieldMahjong {
	class Numbered:Tiles {
		public int Number { get; protected set; }
		public string Color { get; protected set; } = null;
		public Numbered(int number, bool isRed, string type) : base(type) {
			this.Number = number;
			if(number == 5 && isRed == true) {
				Color = "Red";
			}			
		}
		public Numbered() : base() { }
	}
}
