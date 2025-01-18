using System;

public class Entry
{
    public string _prompt;
    public string _response;
    public string _date;

    public Entry(string prompt, string response)
    {
        _prompt = prompt;
        _response = response;
        _date = DateTime.Now.ToString("yyyy-MM-dd");
    }

    public string Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        string dateText = theCurrentTime.ToShortDateString();
        return $"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n";
    }

    public string Serialize()
    {
        return $"{_date}|{_prompt}|{_response}";
    }

    public static Entry Deserialize(string serializedEntry)
    {
        string[] parts = serializedEntry.Split('|');
        if (parts.Length == 3)
        {
            return new Entry(parts[1], parts[2]) { _date = parts[0] };
        }
        return null;
    }
}
