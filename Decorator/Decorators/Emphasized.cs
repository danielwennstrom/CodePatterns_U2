namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Emphasized : TagDecorator, IEmphasized
    {
        public Emphasized(ITag tag) : base(tag)
        {
            TagName = "Emphasized";
            TagElementStart = "<em>";
            TagElementEnd = "</em>";
        }
    }
}