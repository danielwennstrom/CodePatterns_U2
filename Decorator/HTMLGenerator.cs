using Design_Patterns_Assignment.Decorator;
using Design_Patterns_Assignment.Decorator.Decorators;

namespace Design_Patterns_Assignment
{
    internal class HTMLGenerator
    {
        public HTMLGenerator()
        { }

        public HTMLGenerator(ITag tag)
        {
            Tag = tag;
        }

        public ITag Tag { get; set; }

        internal string TagProcessor(string tagSelection, string textInput)
        {
            tagSelection = tagSelection.ToLower();
            var taglist = tagSelection.Split(' ');
            foreach (var t in taglist)
            {
                if (t == "bold")
                {
                    Tag = new Bold(Tag);
                }
                if (t == "deleted")
                {
                    Tag = new Deleted(Tag);
                }
                if (t == "emphasized")
                {
                    Tag = new Emphasized(Tag);
                }
                if (t == "important")
                {
                    Tag = new Important(Tag);
                }
                textInput = Tag.GetTagStart() + textInput + Tag.GetTagEnd();
            }
            return textInput;
        }
    }
}