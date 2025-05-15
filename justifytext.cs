/**************************************************************************************
**
**  Paul A. Jones, Jr.
**  Software Developer & Tech Blogger
**  pauljonessoftware.com
**  pauljonessoftware@gmail.com
**
**  Title: Text Justifier
**  Rating: Intermediate
**
**  Description: Write a method that takes a block of text and returns it justified to 
**  a specified line width — meaning each line is spaced so that all lines (except the last) 
**  are exactly the same width.
**
**  Requirements
**  1. Words must not be split between lines.
**  2. Distribute extra spaces as evenly as possible between words.
**  3. The last line should be left-aligned, not justified.
**  4. Minimum width: 10, Maximum width: 80.
**
***************************************************************************************/

Main();

void Main() 
{
    int lineWidth = 24;

    string input = "Oh to talking improve produce in limited offices fifteen an. Wicket " +
        "branch to answer do we. Place are decay men hours tiled. If or of ye throwing " +
        "friendly required. Marianne interest in exertion as. Offering my branched " +
        "confined oh dashwood.";

    List<string> linesOfText = SplitTextIntoLines(input, lineWidth);

    foreach(string line in linesOfText)
    {
        Console.WriteLine(JustifyLine(line, lineWidth));
    }
}

List<string> SplitTextIntoLines(string input, int lineWidth) 
{
    string[] words = input.Split(" ");
    string lineOfText = string.Empty;
    List<string> linesOfText = new List<string>();

    foreach(string word in words) {
        if(lineOfText.Length + word.Length <= lineWidth) {
            lineOfText += word + " ";
        }
        else {
            // add line of text
            linesOfText.Add(lineOfText);  

            // reset lineOfText 
            lineOfText = string.Empty;

            // start new line of text with new word
            lineOfText += word + " ";
        }
    }

    return linesOfText;
}

public string JustifyLine(string input, int lineWidth) 
{
    string lineOutput = string.Empty;
    string[] words = input.Split(" ");
    int spacesToAdd = lineWidth - input.Length;
    
    foreach(string word in words) {
        if(spacesToAdd > 0) {
            lineOutput += word + " " + " ";
            spacesToAdd--;
        }
        else {
            lineOutput += word + " ";
        }
    }

    return lineOutput;
}