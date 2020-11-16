using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise1
{
	class Program
	{
		static void Main(string[] args)
		{
			HIS_DUCK his_duck = new HIS_DUCK(new Fly_The_HIS_Way());
			Console.WriteLine("his duck : " + his_duck.fly() );


			NOT_HIS_DUCK not_his_duck = new NOT_HIS_DUCK(new Fly_NOT_HIS_Way());
			Console.WriteLine("not his duck : " + not_his_duck.fly());
			
		}
	}	
	public class HIS_DUCK : Duck
	{
		public HIS_DUCK(IFlybehavior flyb) : base(flyb)
		{
		}
	}
	public class NOT_HIS_DUCK : Duck
	{
		public NOT_HIS_DUCK(IFlybehavior flyb) : base(flyb)
		{
		}
	}
	public  class Duck
	{
		private IFlybehavior flyb;

		public Duck(IFlybehavior flyb)
		{
			this.flyb = flyb;
		}
		public string fly()
		{
			return flyb.FLY();
		}
	}
	public interface IFlybehavior
	{
		string FLY();
	}
	public class Fly_The_HIS_Way : IFlybehavior
	{
		string IFlybehavior.FLY()
		{
			return "FLY HIS WAY";
		}
		
	}

	public class Fly_NOT_HIS_Way : IFlybehavior
	{
		public string FLY()
		{
			return "FLY NOT HIS WAY";
		}
	}

}
