using Kros.KORM;
using Kros.KORM.Converter;
using Kros.KORM.Metadata;

namespace KrosKormBugTesting
{
    public class DatabaseConfiguration : DatabaseConfigurationBase
    {
        private const string WeatherForecastsTableName = "WeatherForcasts";

        public override void OnModelCreating(ModelConfigurationBuilder modelBuilder)
        {
            modelBuilder.Entity<WeatherForecast>()
                .HasTableName(WeatherForecastsTableName)
                .UseConverterForProperties<string>(NullAndTrimStringConverter.ConvertNullAndTrimString)
                .Property(u => u.Temperatures).UseConverter<JsonToListConverter<string>>();
        }
    }
}
