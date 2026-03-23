namespace knightmoves;
public class ToDo
{
    // Add your code here
    public string chores = "Chores";
    public string[] MarkAsDone = ["laundry", "dishes", "floors"];

    foreach(string[] anything in MarkAsDone) {
        chores -= anything;
    }
}

//should create a method named MarkAsDone that takes an array of todos and returns the modified string array
//should loop through the todos and prepend the string 'done - ' to each todo
