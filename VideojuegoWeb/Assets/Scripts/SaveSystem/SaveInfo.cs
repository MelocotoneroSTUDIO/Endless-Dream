using System;

[Serializable]
public class SaveInfo
{
    public string email;
    public string password;
    public string username;
    public string gender;
    public int age;
    public int completedLevels;
    public int[] levelStars = new int[50];
    public int coins;
}
