using Module2;
using Xunit;


namespace TestModules 
{

    public class ClassBFactoryTests
    {

        [Fact]
        public void can_create_ClassB()
        {
            var c = ClassBFactory.Create();
            Assert.NotNull(c);
            Assert.IsType<ClassB>(c);
        }
    }

}