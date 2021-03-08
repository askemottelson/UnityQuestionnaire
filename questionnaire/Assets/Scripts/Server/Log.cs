using System;
using System.Collections.Generic;

public class Log
{
    private List<Answer> answers = new List<Answer>();
    public List<float> confidences = new List<float>();
    private long start;
    public string order;

    public Log()
    {
        this.start = new System.DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
    }

    public void SetOrder(string order)
    {
        this.order = order;
    }

    public void NewAnswer(int answer, string name, int round)
    {
        this.answers.Add(
            new Answer(answer, name, round)
        );
    }

    public DataLog ToDataLog(bool isTest)
    {
        return new DataLog(answers, isTest, start, order, confidences.ToArray());
    }

    public int NumAnswers()
    {
        return answers.Count;
    }
    
    public List<Answer> CopyAnswers()
    {
        return new List<Answer>(answers);
    }
}

