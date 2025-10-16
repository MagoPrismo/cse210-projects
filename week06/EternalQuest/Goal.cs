public abstract class Goal
{
    protected string _shortName = "";
    protected string _description = "";
    protected int _points = 0;
    protected bool _isComplete = false;

    public Goal(string name, string description, int points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public string GetName()
    {
        return _shortName;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetComplete(bool isComplete)
    {
        _isComplete = isComplete;
    }
    public virtual void RecordEvent() { }

    public virtual bool IsComplete()
    {
        return _isComplete;
    }

    public virtual string GetDetailsString()
    {
        string mark = " ";
        if (IsComplete())
        {
            mark = "X";
        }

        return $"[{mark}] {_shortName} ({_description}) => points: {_points}";
    }
    public virtual string GetStringRepresentation()
    {
        return "";
    }
    
    


    
}