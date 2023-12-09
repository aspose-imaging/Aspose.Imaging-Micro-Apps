// -----------------------------------------------------------------------------------------------------------
// <copyright file="Resize.cs" company="Aspose Pty Ltd" 
//      Copyright (c) 2001-2023 Aspose Pty Ltd. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------
using Aspose.Imaging.Resize.Api.Options;
using Aspose.Imaging.Resize.Api.Tasks;

internal class Runner
{
	static async Task Main(string[] args)
	{
		try
		{
			var options = new ImagingResizeOptions()
			{
				InputImage = "IMG_20230401_121643.jpg",
				ToFormat = "png",
				ResizeFactor = 150,
				KeepAspectRatio = true,
				OutputImagePath = "IMG_20230401_121643.jpg_with_increased_size.png"
			};

			// You may set path to your Aspose.Imaging .NET license file via parameters						
			if (args.Length > 0 && File.Exists(args[0]))
			{
				options.LicenseFile = args[0];
			}

			await ResizeTasks.Create(options).Execute();
		}
		catch (Exception ex)
		{
			Console.Write(ex.ToString());
			Thread.Sleep(3000);
			throw;
		}
	}
}