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
    public TypeInfo typeInfo;

    public ReflectionPPPI(TypeInfo typeInfo)
    {
        this.typeInfo = typeInfo;
    }

    private static void ShowInfoAboutMethods(ReflectionPPPI reflection)
    {
        foreach (MethodInfo method in reflection.typeInfo.DeclaredMethods)
        {
            Console.WriteLine("Method: " + method);
        }
    }

    private static void ShowInfoAboutMembers(ReflectionPPPI reflection)
    {
        Console.WriteLine("Members");
        foreach (MemberInfo member in reflection.typeInfo.GetMembers())
        {
            Console.WriteLine("Member: " + member);
        }
    }

    private static void ShowInfoAboutFields(ReflectionPPPI reflection)
    {
        Console.WriteLine("FieldInfo");
        FieldInfo[] fields = reflection.typeInfo.GetFields(BindingFlagsForFieldsInfo());
        for (int i = 0; i < fields.Length; i++)
        {
            Console.WriteLine("Name            : {0}", fields[i].Name);
            Console.WriteLine("Declaring Type  : {0}", fields[i].DeclaringType);
            Console.WriteLine("MemberType      : {0}", fields[i].MemberType);
            Console.WriteLine("FieldType       : {0}", fields[i].FieldType);
            Console.WriteLine();
        }
    }

    private static void ShowInfoAboutMethod(ReflectionPPPI reflection)
    {
        MethodInfo ?methodInfo = reflection.typeInfo.GetDeclaredMethod("SetId");
        Console.WriteLine("Info about SetId method");
        Console.WriteLine("Return Type: " + methodInfo.ReturnType);
        Console.WriteLine("Return parameter: " + methodInfo.ReturnParameter);
        Console.WriteLine("Is abstract: " + methodInfo.IsAbstract);
        Console.WriteLine("Is public: " + methodInfo.IsPublic + "\n");
    }

    private static void ShowInfoAboutTypeField(ReflectionPPPI reflection)
    {
        reflection.name = "Banana";
        Type type = reflection.name.GetType();
        Console.WriteLine(type);
    }

    private static void InvokeMethodByReflection(ReflectionPPPI reflectionPPPI)
    {
        Console.WriteLine("Invoke method with Reflection");
        reflectionPPPI.typeInfo.GetDeclaredMethod("SetId")?.Invoke(reflectionPPPI, new object[] { 5 });
        Console.WriteLine("Id is " + reflectionPPPI.GetId());
    }

    private static BindingFlags BindingFlagsForFieldsInfo()
    {
        return BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Public;
    }

    private static void ShowReflectionTestResults()
    {
        ReflectionPPPI reflection = new ReflectionPPPI(typeof(TestingClass).GetTypeInfo());

        ShowInfoAboutTypeField(reflection);

        Console.WriteLine(reflection.typeInfo);

        ShowInfoAboutMethods(reflection);

        ShowInfoAboutMembers(reflection);

        ShowInfoAboutFields(reflection);

        ShowInfoAboutMethod(reflection);

        InvokeMethodByReflection(reflection);
    }

    public static void Main()
    {
        ShowReflectionTestResults();
    }
}