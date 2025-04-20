/**************************************************************************************
**
**  Paul A. Jones, Jr.
**  Software Developer & Tech Blogger
**  pauljonessoftware.com
**  pauljonessoftware@gmail.com 
**  4/19/2025

**  validatestrongpassword.cs

    Title: Validate a strong password
    Rating: Intermediate

    Objective:
    Write a method that checks if a given password string is strong based on the following criteria:

    ✅ At least 8 characters
    ✅ Contains at least one uppercase letter
    ✅ Contains at least one lowercase letter
    ✅ Contains at least one digit
    ✅ Contains at least one special character (e.g., !@#$%^&*())

**
***************************************************************************************/

private bool isValidLength(string input) {
    return input.Length > 8 ? true : false;
}

// range for uppercase ascii characters 65 - 90
private bool ContainsAtLeastOneUpperCaseLetter(string input) {
    bool isValid = false;
    int charValue = 0;

    foreach(char l in input) {
        charValue = (int)l;

        if(charValue >= 65 && charValue <= 90) {
            isValid = true;
            break;
        }
    }

    return isValid;
}

// range for uppercase ascii characters 97 - 122
private bool ContainsAtLeastOneLowerCaseLetter(string input) {
    bool isValid = false;
    int charValue = 0;

    foreach(char l in input) {
        charValue = (int)l;

        if(charValue >= 97 && charValue <= 122) {
            isValid = true;
            break;
        }
    }

    return isValid;
}

// Contains at least one digit
private bool ContainsAtLeastOneDigit(string input) {
    bool isValid = false;
    int charValue = 0;

    foreach(char l in input) {
        charValue = (int)l;

        if(charValue >= 49 && charValue <= 57) {
            isValid = true;
            break;
        }
    }

    return isValid;
}

// Contains at least one !@#$%
private bool ContainsAtLeastOneSpecialCharacter(string input) {
    bool isValid = false;
    int charValue = 0;

    foreach(char l in input) {
        charValue = (int)l;

        // !, @, #, $, %, ^
        if(charValue == 33 || 
            charValue == 64 || 
            charValue == 35 || 
            charValue == 36 || 
            charValue == 37 || 
            charValue == 94) {
                isValid = true;
                break;
        }
    }

    return isValid;
}

public bool isStrongPassword(string input) {
    bool rtn = false;

    rtn = isValidLength(input) && 
        ContainsAtLeastOneUpperCaseLetter(input) &&
        ContainsAtLeastOneLowerCaseLetter(input) &&
        ContainsAtLeastOneDigit(input) &&
        ContainsAtLeastOneSpecialCharacter(input);

    return rtn;
}

// Console.WriteLine($"Is Valid Length: {isValidLength("PaulAJones")}");
// Console.WriteLine(ContainsAtLeastOneUpperCaseLetter("PaulAJones"));
// Console.WriteLine(ContainsAtLeastOneLowerCaseLetter("PaulAJonesJr"));
// Console.WriteLine(ContainsAtLeastOneDigit("3"));
// Console.WriteLine(ContainsAtLeastOneSpecialCharacter("p!"));
// Console.WriteLine(ContainsAtLeastOneSpecialCharacter("p@"));
// Console.WriteLine(ContainsAtLeastOneSpecialCharacter("p#"));
// Console.WriteLine(ContainsAtLeastOneSpecialCharacter("p$"));
// Console.WriteLine(ContainsAtLeastOneSpecialCharacter("p%"));
// Console.WriteLine(ContainsAtLeastOneSpecialCharacter("p^"));

Console.WriteLine(isStrongPassword("Paulajonesjr1!"));