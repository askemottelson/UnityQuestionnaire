using System;

[System.Serializable]
public class Answer
{
    public int button_value = 0;
    public long timestamp = 0;
    public string name = "";
    public int round_no = 0;
    public int trial;
    public string condition;

    public Answer(int button_value, string name, int round, int trial, string condition)
    {
        this.button_value = button_value;
        this.timestamp = new System.DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
        this.name = name;
        this.round_no = round;
        this.trial = trial;
        this.condition = condition;
    }

}

