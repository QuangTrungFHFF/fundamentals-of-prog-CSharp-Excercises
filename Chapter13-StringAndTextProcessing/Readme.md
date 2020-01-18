## Chapter 13: Strings and Text Processing
This chapter describes different methods for manipulating a text.
### List of exercise
- **Exercise 1:** Describe the strings in C#. What is typical for the string type? Explain which the most important methods of the string class are.
- **Exercise 2:** Write a program that reads a string, reverse it and prints it to the console. For example: "introduction" -> "noitcudortni".  
  - Solution folder: ReverseString
- **Exercise 3:** Write a program that checks whether the parentheses are placed correctly in an arithmetic expression. Example of expression with correctly placed brackets: ((a+b)/5-d). Example of an incorrect expression: )(a+b)).
  - Solution folder: IncorrectExpression
- **Exercise 4:** How many backslashes you must specify as an argument to the method Split(…) in order to split the text by a backslash?
  - Solution folder: BackslashSplit
- **Exercise 5:** Write a program that detects how many times a substring is contained in the text. For example, let’s look for the substring "in" in the text:
  - Solution folder: SubstringCounter
- **Exercise 6:** A text is given. Write a program that modifies the casing of letters to uppercase at all places in the text surrounded by <upcase> and </upcase> tags. Tags cannot be nested.
  - Solution folder: CasingModifier
- **Exercise 7:** Write a program that reads a string from the console (20 characters maximum) and if shorter complements it right with "*" to 20 characters.
  - Solution folder: StringOfTwentyCharacters
- **Exercise 8:** Write a program that converts a given string into the form of array of Unicode escape sequences in the format used in the C# language. Sample input: "Test". Result: "\u0054\u0065\u0073\u0074".
  - Solution folder: StringToUnicodeEscapeSequences
- **Exercise 9:** Write a program that encrypts a text by applying XOR (excluding or) operation between the given source characters and given cipher code. The encryption should be done by applying XOR between the first letter of the text and the first letter of the code, the second letter of the text and the second letter of the code, etc. until the last letter of the code, then goes back to the first letter of the code and the next letter of the text. Print the result as a series of Unicode escape characters \xxxx.  
Sample source text: "Test". Sample cipher code: "ab". The result should be the following: "\u0035\u0007\u0012\u0016".
  - Solution folder: XOREncrypt
- **Exercise 10:** Write a program that extracts from a text all sentences that contain a particular word. We accept that the sentences are separated from each other by the character "." and the words are separated from one another by a character which is not a letter.
  - Solution folder: ExtractSentencesWithParticularWord
- **Exercise 11:** A string is given, composed of several "forbidden" words separated by commas. Also a text is given, containing those words. Write a program that replaces the forbidden words with asterisks.
  - Solution folder: ForbiddenWords
- **Exercise 12:** Write a program that reads a number from console and prints it in 15-character field, aligned right in several ways: as a decimal number, hexadecimal number, percentage, currency and exponential (scientific) notation.
  - Solution folder: NumberFormating
- **Exercise 13:** Write a program that parses an URL in following format:  
    [protocol]://[server]/[resource]   
It should extract from the URL the protocol, server and resource parts. For example, when http://www.cnn.com/video is passed, the result is:
    [protocol]="http"
    [server]="www.cnn.com"
    [resource]="/video"
  - Solution folder: URLParse
- **Exercise 14:** Write a program that reverses the words in a given sentence without changing punctuation and spaces.  
For example: "C# is not C++ and PHP is not Delphi"  "Delphi not is PHP and C++ not is C#".
  - Solution folder: ReverseSentence
- **Exercise 15:** A dictionary is given, which consists of several lines of text. Each line consists of a word and its explanation, separated by a hyphen:  
    .NET – platform for applications from Microsoft  
Write a program that parses the dictionary and then reads words from the console in a loop, gives an explanation for it or writes a message on the console that the word is not into the dictionary.
  - Solution folder: Dictionary
- **Exercise 16:**
  - Solution folder: ReplaceHTMLTags
- **Exercise 17:**
  - Solution folder: DaysCalculator
- **Exercise 18:**
  - Solution folder: DateTimeReader
- **Exercise 19:**
  - Solution folder: EmailsFilter
- **Exercise 20:**
  - Solution folder: ExtractDate
- **Exercise 21:**
  - Solution folder: Palindromes
- **Exercise 22:**
  - Solution folder: CharactersCount
- **Exercise 23:**
  - Solution folder: WordsCount
- **Exercise 24:**
  - Solution folder: RepeatingLetter
- **Exercise 25:**
  - Solution folder: ABCSorting

