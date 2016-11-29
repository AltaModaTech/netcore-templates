using Module1;
using Xunit;


namespace TestModule1 
{

    public class ClassAFactoryTests
    {

        [Fact]
        public void can_create_ClassA()
        {
            int created = 0;

            foreach (var name in TestShared.TestData.Names)
            {
                var c = ClassAFactory.Create(name);
                Assert.NotNull(c);
                Assert.IsType<ClassA>(c);

                Assert.True(c.Name.Equals(name));

                ++created;
            }

            Assert.True(created > 2);
        }

    }

}