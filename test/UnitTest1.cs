using NUnit.Framework;
using lib;

namespace test
{
    public class Tests
    {
        public IWeatherForecast WeatherForecast { get; private set; }

        [SetUp]
        public void Setup()
        {
            this.WeatherForecast = new WeatherForecast();
        }

        [Test]
        public void Should_Create_Instance_Of_WeatherForecast()
        {
            if(!this.WeatherForecast.Equals(null)) {
                Assert.Pass();
            };
        }

        [TestCase(-10, 15)]
        [TestCase(0, 32)]
        [TestCase(10, 49)]
        public void Should_Convert_Temperature_From_C_To_F(int C, int F)
        {
            this.WeatherForecast.TemperatureC = C;
            Assert.AreEqual(this.WeatherForecast.TemperatureF, F);
        }        
    }
}