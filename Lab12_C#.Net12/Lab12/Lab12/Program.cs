using System.Reflection;

class TestingClass
{
    private int id;
    protected string name;
    public float radius;
    public double cost;
    internal bool flag;

    private void SetId(int id)
    {
        this.id = id;
    }

    public int GetId()
    {
        return id;
    }

    public void PrintCost()
    {
        Console.WriteLine(cost);
    }

    protected void ManageFlag()
    {
        flag = Console.ReadLine() == "True";
    }
}

class ReflectionPPPI : TestingClass
{
    private static void GetInfoAboutMethods(IEnumerable<MethodInfo> methodList)
    {
        foreach (MethodInfo method in methodList)
        {
            Console.WriteLine("Method: " + method);
        }
    }

    private static void GetInfoAboutMembers(IEnumerable<MemberInfo> memberList)
    {
        Console.WriteLine("Members");
        foreach (MemberInfo member in memberList)
        {
            Console.WriteLine("Member: " + member);
        }
    }

    private static void GetInfoAboutFields(FieldInfo[] fieldsList)
    {
        Console.WriteLine("FieldInfo");
        for (int i = 0; i < fieldsList.Length; i++)
        {
            Console.WriteLine("Name            : {0}", fieldsList[i].Name);
            Console.WriteLine("Declaring Type  : {0}", fieldsList[i].DeclaringType);
            Console.WriteLine("MemberType      : {0}", fieldsList[i].MemberType);
            Console.WriteLine("FieldType       : {0}", fieldsList[i].FieldType);
            Console.WriteLine();
        }
    }

    private static void GetInfoAboutMethod(MethodInfo ?methodInfo)
    {
        Console.WriteLine("Info about SetId method");
        Console.WriteLine("Return Type: " + methodInfo.ReturnType);
        Console.WriteLine("Return parameter: " + methodInfo.ReturnParameter);
        Console.WriteLine("Is abstract: " + methodInfo.IsAbstract);
        Console.WriteLine("Is public: " + methodInfo.IsPublic + "\n");
    }

    private static void InvokeMethodByReflection(ReflectionPPPI reflectionPPPI, MethodInfo ?methodInfo)
    {
        Console.WriteLine("Invoke method with Reflection");
        methodInfo?.Invoke(reflectionPPPI, new object[] { 5 });
        Console.WriteLine("Id is " + reflectionPPPI.GetId());
    }

    private static BindingFlags BindingFlagsForFieldsInfo()
    {
        return BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public;
    }

    private static void TestingClassMethod()
    {
        ReflectionPPPI reflection = new ReflectionPPPI();
        reflection.name = "Banana";
        System.Type type = reflection.name.GetType();
        Console.WriteLine(type);
        TypeInfo type1 = typeof(TestingClass).GetTypeInfo();
        Console.WriteLine(type1);

        GetInfoAboutMethods(type1.DeclaredMethods);

        GetInfoAboutMembers(type1.GetMembers());

        GetInfoAboutFields(type1.GetFields(BindingFlagsForFieldsInfo()));

        MethodInfo? methodInfo = type1.GetDeclaredMethod("SetId");

        GetInfoAboutMethod(methodInfo);

        InvokeMethodByReflection(reflection, methodInfo);
    }

    public static void Main()
    {
        TestingClassMethod();
    }
}