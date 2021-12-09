namespace Design_Patterns_Assignment.Decorator.Decorators
{
    internal class Important : TagDecorator, IImportant
    {
        public Important(ITag tag) : base(tag)
        {
            TagName = "Important";
            TagElementStart = "<strong>";
            TagElementEnd = "</strong>";
        }
    }
}