var verbose = false;
var parseOptions = true;
var values = new List<string>();

foreach (var argument in args)
{
    if (parseOptions && argument == "--")
        parseOptions = false;
    else if (parseOptions && argument == "--verbose")
        verbose = true;
    else
        values.Add(argument);
}

var greeting = Environment.GetEnvironmentVariable("APP_GREETING");
Console.WriteLine($"APP_GREETING: {greeting ?? "Not set"}");

if (verbose)
    Console.WriteLine($"Verbose mode: enabled | Process ID: {Environment.ProcessId}");

if (values.Count == 0)
{
    Console.WriteLine("No arguments provided");
    return;
}

Console.WriteLine($"Received {values.Count} arguments:");
for (var index = 0; index < values.Count; index++)
    Console.WriteLine($"  [{index}]: {values[index]}");
