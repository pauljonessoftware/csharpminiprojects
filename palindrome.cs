/**************************************************************************************
**
**  Paul A. Jones, Jr.
**  Software Developer & Tech Blogger
**  pauljonessoftware.com
**  pauljonessoftware@gmail.com
**
**  C# Tutorial: Palindrome Checker
**  Rating: Intermediate
**
**  Description: Write a method that checks whether a given string is a palindrome—a word, 
**  phrase, or sequence that reads the same forward and backward, ignoring spaces, 
**  punctuation, and case.
**
***************************************************************************************/

// Remove spaces from input
public string stripSpaces(string input) {
    string output = string.Empty;

    foreach(char letter in input) {
        if(letter == ' ') {
            continue;
        }
        else {
            output += letter;
        }
    }

    return output;
}

// Reverse input
public string reverseInput(string input) {
    int ctr = 0;
    int length = input.Length;
    char[] output = new char[length];

    for(int i = length - 1; i >= 0; i--) {
        output[ctr] = input[i];
        ctr++;
    }

    return string.Join("", output);
}

public void Display(string input, string reversedInput) {
    input = stripSpaces(input.ToLower());
    reversedInput = stripSpaces(reversedInput.ToLower());

    Console.WriteLine($"input: {input}");
    Console.WriteLine($"reversedInput: {reversedInput}");
    
    if(input == reversedInput) {
        Console.WriteLine($"{input} is a palindrome");
    }
    else {
        Console.WriteLine($"{input} is NOT a palindrome");    
    }
}

// Is 'racecar' a palindrome?
string input = "racecar";
string reversedInput = stripSpaces(reverseInput(input));
Display(input, reversedInput);

Console.WriteLine("");

// Is 'A man a plan a canal Panama' a palindrome?
input = "A man a plan a canal Panama";
reversedInput = stripSpaces(reverseInput(input));
Display(input, reversedInput);