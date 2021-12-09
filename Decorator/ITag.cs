namespace Design_Patterns_Assignment.Decorator
{
    internal interface ITag
    {
        string TagName { get; set; }
        string TagElementStart { get; set; }
        string TagElementEnd { get; set; }

        string GetTagStart();

        string GetTagEnd();
    }
}