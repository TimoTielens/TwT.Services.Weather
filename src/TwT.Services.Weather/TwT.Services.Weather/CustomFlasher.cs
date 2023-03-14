using MassTransit;
using TwT.Modules.Base;

namespace TwT.Services.Weather
{
	public class CustomFlasher : Flasher
	{
		public CustomFlasher(string[] arguments) : base(arguments)
		{

		}

		protected override void FlashServices(IServiceCollection services, IConfiguration configuration)
		{
			//throw new NotImplementedException();
		}

		protected override void FlashMassTransitConsumers(IBusRegistrationConfigurator busRegistrationConfigurator)
		{
			//	busRegistrationConfigurator.AddConsumer<>();
		}
	}
}