namespace PracticalApplication.Test.WebApi.TheoryTest
{
    public class AuthTheory : TheoryData<object, string, string>
    {
        public AuthTheory()
        {
            Add(new { User = "tets",  }, "tests", "" );
            Add(new { User = "tets", tikon = "tokenTest" }, "tests", "test1223");
        }
    }
}
