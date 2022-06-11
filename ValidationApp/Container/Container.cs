using System.Reflection;

namespace Container;

public class Container
{
    private readonly Dictionary<Type, Type> types=new Dictionary<Type, Type>();

    public void Register<TInterface, TImplementation>() where TImplementation : TInterface
    {
        types[typeof(TInterface)] = typeof(TImplementation);
    }

    public TInterface Create<TInterface>()
    {
        return (TInterface)Create(typeof(TInterface));
    }

    private object Create(Type type)
    {
        Type concrete_type = types[type];
        ConstructorInfo constructor_default = concrete_type.GetConstructors()[0];
        ParameterInfo[] params_default = constructor_default.GetParameters();
        object[] parameters = params_default.Select(param => Create(param.ParameterType)).ToArray();

        return constructor_default.Invoke(parameters);
    }

}