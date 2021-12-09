namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Bold : TagDecorator, IBold
    {
        public Bold(ITag tag) : base(tag)
        {
            TagName = "Bold";
            TagElementStart = "<b>";
            TagElementEnd = "</b>";
        }
    }
}