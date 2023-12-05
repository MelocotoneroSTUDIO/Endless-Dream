using System;

[Serializable]
public class DataClass
{
    public string ID = "";
    public string gender = null;
    public int age = 0;
    public string level = "";
    public int interactions = 0;
    public float time = 0;
    public int coins = 0;
    public int treasures = 0;
    public int deaths = 0;

    public string DataToString() 
    {
        string result="";

        result = result + "ID: " + ID + "\n";
        result = result + "Age: " + age + "\n";
        result = result + "Gender: " + gender + "\n";
        result = result + "Level: " + level + "\n";
        result = result + "Interacions: " + interactions + "\n";
        result = result + "Time: " + time.ToString("0.00") + "\n";
        result = result + "Coins: " + coins + "\n";
        result = result + "Treasures: " + treasures + "\n";
        result = result + "Deaths: " + deaths + "\n";

        return result;
    }

    public string DataToJson() 
    {
        string json ="";

        return json;
    }
}
