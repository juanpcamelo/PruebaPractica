using MongoDB.Bson.Serialization.Attributes;

namespace PracticalApplication.Domain.Customer
{
    public sealed class CustomerPolicy : BaseEntity
    {
        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;
        [BsonElement("identification")]
        public string Identification { get; set; } = string.Empty;
        [BsonElement("birthDate")]
        public DateTime BirthDate { get; set; }
        [BsonElement("polizaStartDate ")]
        public DateTime PolizaStartDate { get; set; }
        [BsonElement("polizaEndDate ")]
        public DateTime PolizaEndDate { get; set; }
        [BsonElement("coverage")]
        public string Coverage { get; set; } = string.Empty;
        [BsonElement("maxCoverage")]
        public int MaxCoverage { get; set;}
        [BsonElement("namePoliza ")]
        public string NamePoliza { get; set; } = string.Empty;
        [BsonElement("cityResidence")]
        public string CityResidence { get; set; } = string.Empty;
        [BsonElement("addressResidence")]
        public string AddressResidence { get; set; } = string.Empty;
        [BsonElement("placaAutomotor")]
        public string PlacaAutomotor { get; set; } = string.Empty;
        [BsonElement("vehicleInspection")]
        public string VehicleInspection { get; set; } = string.Empty;
    }
}
