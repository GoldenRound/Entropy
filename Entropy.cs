using Terraria.ModLoader;

namespace Entropy
{
	class Entropy : Mod
	{
		public Entropy()
		{
			Properties = new ModProperties()
			{
				Autoload = true,
				AutoloadGores = true,
				AutoloadSounds = true
			};
		}
	}
}
