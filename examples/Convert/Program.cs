// -----------------------------------------------------------------------------------------------------------
// <copyright file="Converter.cs" company="Aspose Pty Ltd" 
//      Copyright (c) 2001-2023 Aspose Pty Ltd. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------
using Aspose.Imaging.Convert.Api.Options;
using Aspose.Imaging.Convert.Api.Tasks;

internal class Runner
{
	static async Task Main(string[] args)
	{
		try
		{
			var options = new ImagingConvertOptions()
			{
				InputImage = "couple.png",
				ToFormat = "jpg",
				OutputImagePath = "couple.jpg"
			};

			// You may set path to your Aspose.Imaging .NET license file via parameters
			if (args.Length > 0 && File.Exists(args[0]))
			{
				options.LicenseFile = args[0];
			}

			await ConvertTasks.Create(options).Execute();
		}
		catch (Exception ex)
		{
			Console.Write(ex.ToString());
			Thread.Sleep(3000);
			throw;
		}
	}
}