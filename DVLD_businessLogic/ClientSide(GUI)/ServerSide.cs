using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using Newtonsoft.Json;
using System.Threading;

class DictionaryServer
{
    private static readonly string dictionaryFilePath = "C:\\Users\\qaisk\\Documents\\Dictionary.txt";
    private static Dictionary<string, string> dictionary = new Dictionary<string, string>();

    static void Main(string[] args)
    {
        LoadDictionary();
        StartServer();
    }

    static void LoadDictionary()
    {
        try
        {
            foreach (var line in File.ReadLines(dictionaryFilePath))
            {
                var parts = line.Split(':');
                if (parts.Length == 2)
                {
                    dictionary[parts[0].Trim().ToLower()] = parts[1].Trim();
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading dictionary: {ex.Message}");
        }
    }

    static void StartServer()
    {
        TcpListener server = new TcpListener(IPAddress.Any, 5000);
        server.Start();
        Console.WriteLine("Server is running on port 5000...");

        while (true)
        {
            var client = server.AcceptTcpClient();
            Console.WriteLine("Client connected.");
            ThreadPool.QueueUserWorkItem(HandleClient, client);
        }
    }

    static void HandleClient(object obj)
    {
        try
        {
            var client = (TcpClient)obj;
            if (client == null || !client.Connected)
                return;

            NetworkStream stream = client.GetStream();
            StreamReader reader = new StreamReader(stream);
            StreamWriter writer = new StreamWriter(stream) { AutoFlush = true };

            string jsonRequest = reader.ReadLine();
            var request = JsonConvert.DeserializeObject<dynamic>(jsonRequest);
            string word = request?.Word?.ToString().Trim().ToLower();

            var response = new DictionaryResponse { meanings = new List<string>(), error = null };

            if (string.IsNullOrEmpty(word))
            {
                response.error = "Error: Word cannot be null or empty.";
            }
            else if (dictionary.ContainsKey(word))
            {
                response.meanings.Add(dictionary[word]);
            }
            else
            {
                response.error = "Word not found.";
            }

            string jsonResponse = JsonConvert.SerializeObject(response);
            writer.WriteLine(jsonResponse);

            client.Close();
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error handling client: " + ex.Message);
        }
    }
}

public class DictionaryResponse
{
    public List<string> meanings { get; set; }
    public string error { get; set; }
}
