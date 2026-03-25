public class ToDo
{
    public string[] MarkAsDone(string[] todos)
    {
        for (int i = 0; i < todos.Length; i++)
        {
            todos[i] = "done - " + todos[i];
        }
        return todos;
    }
}

//should create a method named MarkAsDone that takes an array of todos and returns the modified string array
//should loop through the todos and prepend the string 'done - ' to each todo
