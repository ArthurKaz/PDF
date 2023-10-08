using System.ComponentModel.DataAnnotations;

namespace PDFOfferCreator.Model
{
	public class OfferData
	{
		public int Id { get; set; }

		[Required]
		[StringLength(100, MinimumLength = 2)]
		public string Name {  get; set; }

		[Required]
		[StringLength(100, MinimumLength = 2)]
		public string Surname { get; set; }
		[Required]
		[StringLength(100, MinimumLength = 2)]
		public string City { get; set; }
		[Required]
		[StringLength(100, MinimumLength = 2)]
		public string Street { get; set; }
		public ModuleType ModuleType { get; set; }	
		public BatteryStorage BatteryStorage { get; set; }

		public OfferData(int id, string name, string surname, string city, string street, ModuleType moduleType, BatteryStorage batteryStorage)
		{
			Id = id;
			Name = name;
			Surname = surname;
			City = city;
			Street = street;
			ModuleType = moduleType;
			BatteryStorage = batteryStorage;
		}
        public OfferData()
        {
            Id = 0;
            Name = "";
            Surname = "";
            City = "";
            Street = "";
            ModuleType = 0;
            BatteryStorage = 0;
        }

    }
}
