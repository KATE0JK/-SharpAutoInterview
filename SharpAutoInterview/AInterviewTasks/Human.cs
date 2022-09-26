namespace InterviewTasks;

public class Human
{
    private string _eyesColor;
    private string _sex;

    public Human(int height, string eyesColor, string sex, List<string> petNames)
    {
        Height = height;
        _eyesColor = eyesColor;
        _sex = sex;
        PetNames = petNames;
    }

    public int Height { get; }

    public List<string> PetNames { get; set; }

    public Human GetCopy()
    {
        List<string> copyPetNames = new List<string>();
        foreach (var petName in PetNames)
        {
            copyPetNames.Add(petName);
        }

        return new Human(Height, _eyesColor, _sex, copyPetNames);
    }
}