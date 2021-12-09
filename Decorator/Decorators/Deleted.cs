namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Deleted : TagDecorator, IBold
    {
        public Deleted(ITag tag) : base(tag)
        {
            TagName = "Deleted";
            TagElementStart = "<del>";
            TagElementEnd = "</del>";
        }
    }
}