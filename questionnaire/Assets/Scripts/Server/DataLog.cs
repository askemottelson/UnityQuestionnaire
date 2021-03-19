using System;
using System.Collections.Generic;
using System.Net;
using UnityEngine;

[System.Serializable]
public class DataLog
{
    public Answer[] answers;
    public bool test;
    public long end;
    public string device;
    public string deviceID;
    public string IP;
    public string order;
    public long start;
    public float[] confidences;
    public long scene_bathroom_start, scene_bathroom_end, scene_gp_start, scene_gp_end;
    public string avatarGender, avatarAge, scenarioCommunication;

    public DataLog(List<Answer> answers, bool isTest, long start, string order, float[] confidences,
        long scene_bathroom_start = 0, long scene_bathroom_end = 0, long scene_gp_start = 0, long scene_gp_end = 0,
        string avatarGender = "", string avatarAge = "", string scenarioCommunication = "")
    {
        this.device = SystemInfo.deviceModel;
        this.deviceID = SystemInfo.deviceUniqueIdentifier;
        this.answers = answers.ToArray();
        this.test = isTest;
        this.end = new System.DateTimeOffset(DateTime.Now).ToUnixTimeSeconds();
        this.start = start;
        this.order = order;
        this.confidences = confidences;
        this.scene_bathroom_start = scene_bathroom_start;
        this.scene_bathroom_end = scene_bathroom_end;
        this.scene_gp_start = scene_gp_start;
        this.scene_gp_end = scene_gp_end;
        this.avatarGender = avatarGender;
        this.avatarAge = avatarAge;
        this.scenarioCommunication = scenarioCommunication;

        if (!isTest)
        {
            this.IP = new WebClient().DownloadString("http://icanhazip.com").Trim();
        }
        else {
            this.IP = "localhost";
        }
    }
}
