using System;
public static class GlobalVariables
{
    public static bool TeachMe = true;

    public static bool ClosedCaptioningEnabled = true;
    public static int LanguagePref = 0;
    public static bool CourseComplete = false;
    public static bool initialCenteringComplete = false;
    public static bool[] ModuleCompleted = new bool[3];
    public static bool firstRunComplete;
    // 0 tutorial
    // 1 active threat
    // 2 stop the bleed
}
