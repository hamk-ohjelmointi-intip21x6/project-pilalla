using System.IO;
using Newtonsoft.Json;

namespace Palkanlaskenta
{
	public static class Save
	{
		public static T ReadFromJsonFile<T>(string filePath) where T : new()
		{
			TextReader reader = null;
			try
			{
				reader = new StreamReader(filePath);
				var fileContents = reader.ReadToEnd();

				/*Console.WriteLine("fileContents: " + fileContents);
				Console.WriteLine("deserialized: " + JsonConvert.DeserializeObject<T>(fileContents));*/

				return JsonConvert.DeserializeObject<T>(fileContents);
			}
			catch
			{
				return default; //null
			}
			finally
			{
				if (reader != null)
					reader.Close();
			}
		}

		public static void WriteToJsonFile<T>(string filePath, T objectToWrite) where T : new()
		{
			TextWriter writer = null;
			try
			{
				var writeToFile = JsonConvert.SerializeObject(objectToWrite);
				writer = new StreamWriter(filePath, false);
				writer.Write(writeToFile);
			}
			finally
			{
				if (writer != null)
					writer.Close();
			}
		}

	}
}
