namespace Design_Patterns_Assignment.Decorator
{
    internal abstract class TagDecorator : ITag
    {
        public TagDecorator(ITag tag)
        {
            Tag = tag;
        }

        public ITag Tag { get; set; }
        public string TagName { get; set; }
        public string TagElementStart { get; set; }
        public string TagElementEnd { get; set; }

        public string GetTagStart()
        {
            return TagElementStart;
        }

        public string GetTagEnd()
        {
            return TagElementEnd;
        }
    }
}