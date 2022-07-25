using FluentAssertions;
using WebApi.Model;

namespace DomainTestes
{
    public class CalculadoraTests
    {
        public static IEnumerable<object[]> DadosTestes =>
          new object[][]
          {
              new object[] { 10,10,20 },
          };
        [Theory]
        [MemberData(nameof(DadosTestes))]
        public void DeveSomarDoisNumero(decimal one,decimal two,decimal expected)
        {
            var sut = new Calculadora();

            var result = sut.Sum(one, two);

            result.Should().Be(expected);
        }
    }
}