namespace Design_Patterns_Assignment.Decorator
{
    internal abstract class TagDecorator : ITag
    {
        public TagDecorator(ITag tag)
        {
            Tag = tag;
        }

        public ITag Tag { get; set; }
        public string TagName;
        public string TagElementStart;
        public string TagElementEnd;

        public string GetTagStart()
        {
            return Tag.GetTagStart() + TagElementStart;
        }

        public string GetTagEnd()
        {
            return TagElementEnd + Tag.GetTagEnd();
        }
    }
}