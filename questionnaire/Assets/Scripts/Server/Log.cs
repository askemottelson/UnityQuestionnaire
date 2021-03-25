using System;
using System.Collections.Generic;

public class Log
{
    private List<Answer> answers = new List<Answer>();
    public List<float> confidences = new List<float>();
    //private long start;
    public string order;

    public long
        intro_pre_questionnaire,
        intro_post_questionnaire,
        bathroom_start,
        gp_start,
        gp_pre_questionnaire,
        gp_post_questionnaire;

    public float walkedDistance, lookAtMirrorTime;

    public string
        avatar_gender,
        condition_age,
        condition_communication;

    //public Log()
    //{
    //    this.start = new System.DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
    //}

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
        //return new DataLog(answers, isTest, start, order, confidences.ToArray());
        throw new Exception("Deprecated in VRHI branch.");
    }

    public DataLog ToDataLogWithTimestamps(bool isTest)
    {
        //return new DataLog(answers, isTest, start, order, confidences.ToArray(), intro_pre_questionnaire, intro_post_questionnaire, bathroom_start, gp_start, avatar_gender, condition_age, condition_communication);
        throw new Exception("Deprecated in VRHI branch.");
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

