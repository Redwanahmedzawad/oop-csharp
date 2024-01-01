using System;
using System.Collections.Generic;
using SplashKitSDK;

namespace splashkitdem
{
	public class FruitKarate
	{
		private List<Fruit> _fruit;

		public FruitKarate()
		{
			_fruit = new List<Fruit>();
		}

		public void LaunchFruit()
		{
			Fruit f = new Fruit();
			_fruit.Add(f);
		}

		public void Update()
		{
			foreach (Fruit f in _fruit)
			{
				f.Update();
			}
		}

		public void Draw()
		{
			foreach (Fruit f in _fruit)
			{
				f.Draw();
			}
		}
		public void Slash(Point2D pt)
        {
			List<Fruit> toremove = new List<Fruit>(_fruit);
			foreach( Fruit f in _fruit)
            {
				if (f.IsAt(pt))
                {
					toremove.Add(f); 
                }
            }
			foreach(Fruit f in toremove)
            {
				_fruit.Remove(f);
            }
        }
	}
}
