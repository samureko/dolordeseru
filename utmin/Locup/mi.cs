string htmlContent = "Your HTML content here";
Match m2 = Regex.Match(htmlContent, @"href=\""(.*?)\""", RegexOptions.Singleline);
if (m2.Success)
{
    string hrefValue = m2.Groups[1].Value;
    Console.WriteLine("Found URL: " + hrefValue);
}
