using Machine.Specifications;

namespace FizzBussKata.specs
{
    public class When_the_number_is_3
    {
        private static Fizzbuzz _fizzbuzz;
        private static string _result;

        Establish context = () =>
        {
            _fizzbuzz = new Fizzbuzz();
        };

        Because of = () =>
        {
            _result = _fizzbuzz.FizzBuzz(3);
        };


        //assertion
        It should_fizz = () => _result.ShouldEqual("Fizz");

    }


}
