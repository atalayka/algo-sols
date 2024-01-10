public class Kata
{
  public static string ReplaceNth(string text, int n, char oldValue, char newValue)
  {
    // Check if the input parameters are valid.
    if (n <= 0 || n > text.Length)
    {
      return text;
    }

    // Create a new string builder to store the replaced text.
    System.Text.StringBuilder sb = new System.Text.StringBuilder();

    // Iterate over the text string, keeping track of the number of times oldValue has been encountered.
    int count = 0;
    foreach (char c in text)
    {
      if (c == oldValue && ++count % n == 0)
      {
        // If the current index is a multiple of n and the current character is oldValue, append the newValue character to the StringBuilder object.
        sb.Append(newValue);
      }
      else
      {
        // Otherwise, append the current character to the StringBuilder object.
        sb.Append(c);
      }
    }

    // Return the replaced text.
    return sb.ToString();
  }
}