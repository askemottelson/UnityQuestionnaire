using System;

[Serializable]
public class DataLog
{
    public Answer[] answers;
    public bool test;
    public string device, deviceID, IP, order;
    public float[] confidences;

    public long
        intro_pre_questionnaire,
        intro_post_questionnaire,
        bathroom_start,
        gp_start,
        gp_pre_questionnaire,
        gp_post_questionnaire;

    public float walked_distance, look_at_mirror_time;
    public float hmd_movement, hmd_rotation, l_touch_movement, r_touch_movement;

    public string
        avatar_gender,
        condition_age,
        condition_communication;
}
