﻿namespace Shared; 

public class Logger {
    public string Name { get; }
    public Logger(string name) {
        Name = name;
    }

    public void Info(string text) {
        Console.ResetColor();
        Console.WriteLine($"Info [{Name}] {text}");
    }

    public void Warn(string text) {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"Warn [{Name}] {text}");
    }

    public void Error(string text) {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Warn [{Name}] {text}");
    }
}