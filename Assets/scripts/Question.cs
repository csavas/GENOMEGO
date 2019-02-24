[System.Serializable]
public class Question
{
    //question, answers, index of correct answer
    public string question;
    public string[] ans;
    public int correct;
    public string explanation; //explanation of correct answer

    //sticker, clue, description, name
    public string clue;
    public string description;
    public UnityEngine.UI.Image yo; 
    //public string geneid; //also name of sticker
}
