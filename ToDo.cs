public class ToDo
{
    public string[] MarkAsDone(string[] todos)
    {
        string[] result = new string[todos.Length];
        int i = 0;

        foreach (string todo in todos)
        {
            result[i] = "done - " + todo;
            i++;
        }

        return result;
    }
}

//should create a method named MarkAsDone that takes an array of todos and returns the modified string array
//should loop through the todos and prepend the string 'done - ' to each todo
