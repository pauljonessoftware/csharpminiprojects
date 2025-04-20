/**************************************************************************************
**
**  Paul A. Jones, Jr.
**  Software Developer & Tech Blogger
**  pauljonessoftware.com
**  pauljonessoftware@gmail.com
**
**  C# Tutorial: Reverse Words in a Sentence
**  Rating: Beginner
**
**  Description: Write a method that takes a sentence as input and returns the sentence
**  with the order of words reversed. Do not use Array.Reverse().
**
**  Example
**  Input: "The quick brown fox"
**  Output: "fox brown quick The"
**
***************************************************************************************/

// Reverse and display sentence
Console.WriteLine(reverseSentence("The quick brown fox"));

public string reverseSentence(string input) {
    string output = string.Empty;

    string[] sentence = input.Split(' ');
    int length = sentence.Length;

    for(int i = length - 1; i >= 0; i--) {
        if(i != 0) {
            output += sentence[i] + " ";
        }
        else {
            // don't add space after last word
            output += sentence[i];
        }
    }

    return output;
}

// Reverse and display sentence
Console.WriteLine(reverseSentence2("The quick brown fox"));

public string reverseSentence2(string input) {
    string[] sentence = input.Split(' ');
    int length = sentence.Length;
    string[] output = new string[length];
    int ctr = 0;

    for(int i = length - 1; i >= 0; i--) {
        output[ctr] = sentence[i];
        ctr++;
    }

    return string.Join(" ", output);
}
