using System.ComponentModel.Design;
using System.Runtime.Serialization;
using RepositoryPattern.Repository;

namespace RepositoryPattern.Console;

public class ProgramUI
{
    private StreamingContentRepository _contentRepo = new StreamingContentRepository();

    // Method that run/starts the application
    public void Run()
    {
        SeedContentList();
        Menu();
    }

    //Menu
    private void Menu()
    {
        bool keepRunning = true;

        while (keepRunning)
        {
            // Display our options to the user
            System.Console.WriteLine("Select a menu options:\n" +
                "1. Create New Content\n" +
                "2. View All Content\n" +
                "3. View Content By Title\n" +
                "4. Update Existing Content\n" +
                "5. Delete Existing Content\n" +
                "6. Exit");

            // Get the user's input
            string input = System.Console.ReadLine();

            // Evaluate the user's input and act accordingly
            switch (input)
            {
                case "1":
                    // Create new content
                    CreateNewContent();
                    break;
                case "2":
                    // View all content
                    DisplayAllContent();
                    break;
                case "3":
                    // View content by title
                    DisplayContentByTitle();
                    break;
                case "4":
                    // Update existing content
                    UpdateExistingContent();
                    break;
                case "5":
                    // Delete existing content
                    DeleteExistingContent();
                    break;
                case "6":
                    // Exit
                    System.Console.WriteLine("Goodbye!");
                    keepRunning = false;
                    break;
                default:
                    System.Console.WriteLine("Please enter a valid number.");
                    break;
            }

            System.Console.WriteLine("Please press any key to continue...");
            System.Console.ReadKey();
            System.Console.Clear();
        }
    }

    // Create new StreamingContent
    private void CreateNewContent()
    {
        System.Console.Clear();
        StreamingContent newContent = CreateNewStreamingContentObject();
        _contentRepo.AddContentToList(newContent);
    }

    // View current StreamingContent that is save
    private void DisplayAllContent()
    {
        System.Console.Clear();

        List<StreamingContent> listOfContent = _contentRepo.GetContentList();
        foreach (StreamingContent content in listOfContent)
        {
            System.Console.WriteLine($"Title: {content.Title}\n" +
                $"Desc: {content.Description}");
        }
    }

    // View existing Content by title
    private void DisplayContentByTitle()
    {
        System.Console.Clear();

        // Prompt the user to give us a title
        System.Console.WriteLine("Enter the title of the content you'd like to see:");

        // Get the user's input
        string title = System.Console.ReadLine();

        // Find the content by that title
        var content = _contentRepo.GetContentByTitle(title);

        // Display said content if it isn't null
        if (content != null)
        {
            System.Console.WriteLine($"Title: {content.Title}\n" +
                $"Description: {content.Description}\n" +
                $"Maturity Rating: {content.MaturityRating}\n" +
                $"Stars: {content.StarRating}\n" +
                $"Is Family Friendly: {content.IsFamilyFriendly}\n" +
                $"Genre: {content.TypeOfGenre}");
        }
        else
        {
            System.Console.WriteLine("No content by that title.");
        }
    }

    // Update existing content
    private void UpdateExistingContent()
    {
        // Display all content
        DisplayAllContent();

        // Ask for the title of the content to update
        System.Console.WriteLine("Enter the title of the content you would like to update:");

        // Get that title
        string oldTitle = System.Console.ReadLine();
        StreamingContent newContent = CreateNewStreamingContentObject();

        // Verify the update worked
        bool wasUpdated = _contentRepo.UpdateExistingContent(oldTitle, newContent);

        if (wasUpdated)
        {
            System.Console.WriteLine("Content successfully updated.");
        }
        else
        {
            System.Console.WriteLine("Could not update content.");
        }
    }

    private static StreamingContent CreateNewStreamingContentObject()
    {
        // We will build a new object
        StreamingContent newContent = new StreamingContent();

        // Title
        System.Console.WriteLine("Enter the title for the content:");
        newContent.Title = System.Console.ReadLine();

        // Description
        System.Console.WriteLine("Enter the description for the content:");
        newContent.Description = System.Console.ReadLine();

        // Maturity Rating
        System.Console.WriteLine("Enter the rating for the content: (G, PG, PG-13, etc)");
        newContent.MaturityRating = System.Console.ReadLine();

        // Star Rating
        System.Console.WriteLine("Enter the star count for the content: (5.8, 10, 1.5, etc)");
        string starsAsRating = System.Console.ReadLine();
        newContent.StarRating = double.Parse(starsAsRating);

        // IsFamilyFriendly
        System.Console.WriteLine("Is this content family friendly?");
        string familyFriendlyString = System.Console.ReadLine().ToLower();

        if (familyFriendlyString == "y")
        {
            newContent.IsFamilyFriendly = true;
        }
        else
        {
            newContent.IsFamilyFriendly = false;
        }

        // GenreType
        System.Console.WriteLine("Enter the Genre Number: \n" +
            "1. Horror\n" +
            "2. RomCom\n" +
            "3. SciFi\n" +
            "4. Documentary\n" +
            "5. Bromance\n" +
            "6. Drama\n" +
            "7. Action");

        string genreAsString = System.Console.ReadLine();
        int genreAsInt = int.Parse(genreAsString);
        newContent.TypeOfGenre = (GenreType)genreAsInt;
        return newContent;
    }

    // Delete existing content
    private void DeleteExistingContent()
    {
        // System.Console.Clear();

        DisplayAllContent();

        // Get the title they want to remove
        System.Console.WriteLine("\nEnter the title of the content you would like to remove:");
        string input = System.Console.ReadLine();

        // Call the delete method
        bool wasDeleted = _contentRepo.RemoveContentFromList(input);

        // If the content was deleted, say so
        // Otherwise state that it could not be deleted
        if (wasDeleted)
        {
            System.Console.WriteLine("The content was successfully deleted.");
        }
        else
        {
            System.Console.WriteLine("The conent could not be deleted.");
        }
    }

    private void SeedContentList()
    {
        StreamingContent sharknado = new StreamingContent("Sharknado", "Tornados, but with sharks.", "TV-14", 3.3, true, GenreType.Action);
        StreamingContent theBlob = new StreamingContent("The Blob", "Gelatinous alien life form takes over a small town.", "PG", 4.6, false, GenreType.SciFi);
        StreamingContent toyStory = new StreamingContent("Toy Story", "The secret life of toys.", "G", 9.5, true, GenreType.RomCom);

        _contentRepo.AddContentToList(sharknado);
        _contentRepo.AddContentToList(theBlob);
        _contentRepo.AddContentToList(toyStory);
    }
}