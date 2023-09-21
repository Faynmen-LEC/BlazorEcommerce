using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DriversController : ControllerBase
	{
		private static List<Driver> Drivers = new List<Driver>
	{
		new Driver
		{
			Id=1,Name="Charles Leclerc",Team="Ferrari",
			ImageUrl="https://media.formula1.com/d_driver_fallback_image.png/content/dam/fom-website/drivers/C/CHALEC01_Charles_Leclerc/chalec01.png.transform/2col/image.png",Number=16
		},
		new Driver
		{
			Id=2,Name="Carlos Sainz",Team="Ferrari",
			ImageUrl="https://media.formula1.com/d_driver_fallback_image.png/content/dam/fom-website/drivers/C/CARSAI01_Carlos_Sainz/carsai01.png.transform/2col/image.png",Number=55
		},
		new Driver
		{
			Id=3,Name="Max Verstappen",Team="Red Bull",
			ImageUrl="https://media.formula1.com/d_driver_fallback_image.png/content/dam/fom-website/drivers/M/MAXVER01_Max_Verstappen/maxver01.png.transform/2col/image.png",Number=33
		},
		new Driver
		{
			Id=4,Name="Sergio Perez",Team="Red Bull",
			ImageUrl="https://media.formula1.com/d_driver_fallback_image.png/content/dam/fom-website/drivers/S/SERPER01_Sergio_Perez/serper01.png.transform/2col/image.png",Number=11
		},
		new Driver
		{
			Id=5,Name="Lando Norris",Team="McLaren",
			ImageUrl="https://media.formula1.com/d_driver_fallback_image.png/content/dam/fom-website/drivers/L/LANNOR01_Lando_Norris/lannor01.png.transform/2col/image.png",Number=4
		},
		new Driver
		{
			Id=6,Name="Lewis Hamilton",Team="Mercedes",
			ImageUrl="https://media.formula1.com/d_driver_fallback_image.png/content/dam/fom-website/drivers/L/LEWHAM01_Lewis_Hamilton/lewham01.png.transform/2col/image.png",Number=44
		},
		new Driver
		{
			Id=7,Name="Fernando Alonso",Team="Aston Martin",
			ImageUrl="https://media.formula1.com/d_driver_fallback_image.png/content/dam/fom-website/drivers/F/FERALO01_Fernando_Alonso/feralo01.png.transform/2col/image.png",Number=14
		},
	};

		[HttpGet]
		public async Task<ActionResult<List<Driver>>> GetDriver()
		{
			return Ok(Drivers);
		}
	}

	
}
