namespace MockQueryable2;

[TestClass]
public sealed class TestClass2
{
    [AssemblyInitialize]
    public static void AssemblyInit(TestContext context)
    {
        // This method is called once for the test assembly, before any tests are run.
        Debug.WriteLine(nameof(AssemblyInit));
    }

    [AssemblyCleanup]
    public static void AssemblyCleanup()
    {
        // This method is called once for the test assembly, after all tests are run.
        Debug.WriteLine(nameof(AssemblyCleanup));
    }

    [ClassInitialize]
    public static void ClassInit(TestContext context)
    {
        // This method is called once for the test class, before any tests of the class are run.
        Debug.WriteLine(nameof(ClassInit));
    }

    [ClassCleanup]
    public static void ClassCleanup()
    {
        // This method is called once for the test class, after all tests of the class are run.
        Debug.WriteLine(nameof(ClassCleanup));
    }

    [TestInitialize]
    public void TestInit()
    {
        // This method is called before each test method.
        Debug.WriteLine(nameof(TestInit));
    }

    [TestCleanup]
    public void TestCleanup()
    {
        // This method is called after each test method.
        Debug.WriteLine(nameof(TestCleanup));
    }

    [TestMethod]
    public void TestMethod2()
    {
        Debug.WriteLine(nameof(TestMethod2));
    }
}
