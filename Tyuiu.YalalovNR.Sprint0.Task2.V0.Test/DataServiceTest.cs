using Tyuiu.YalalovNR.Sprint0.Task2.V0.Lib;
namespace Tyuiu.YalalovNR.Sprint0.Task2.V0.Test
{
    public class DataServiceTest
    {
        [Fact]
        public void CheckMessageValid()
        {
            var name = "Игорь";
            var res = DataService.GetMessage(name);
            Assert.Equal("Привет...,Игорь",res);
        }
    }
}