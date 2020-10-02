using System;
using System.Collections.Generic;
using System.Text;

namespace MinefieldMahjong {
	class Honors : Tiles {
		public string HonorType { get; protected set; }
		public Honors(string isHonor, string whatHonor):base(isHonor) { HonorType = whatHonor; }

	}
}
