using Machine.Specifications;

namespace FizzBussKata.specs
{
    public class When_creating_fizzbuss
    {
        private static Fizzbuzz _fizzbuzz;

        Establish context = () =>
        {
            _fizzbuzz = new Fizzbuzz();
        };

        It should_not_be_null = () => _fizzbuzz.ShouldNotBeNull();
    }
}
