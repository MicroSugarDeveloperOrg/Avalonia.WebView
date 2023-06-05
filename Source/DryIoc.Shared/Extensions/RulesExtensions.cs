namespace DryIoc.Shared.Extensions;
public class RulesExtensions
{


    public static Rules DefaultRules= Rules.Default.WithConcreteTypeDynamicRegistrations(reuse: Reuse.Transient)
                                                   .With(Made.Of(FactoryMethod.ConstructorWithResolvableArguments))
                                                   .WithFuncAndLazyWithoutRegistration()
                                                   .WithTrackingDisposableTransients()
                                                   //.WithoutFastExpressionCompiler()
                                                   .WithFactorySelector(Rules.SelectLastRegisteredFactory());
}
