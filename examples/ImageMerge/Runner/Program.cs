// -----------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Aspose Pty Ltd" author="Alexander Feigin">
//      Copyright (c) 2001-2023 Aspose Pty Ltd. All rights reserved.
// </copyright>
// ---------------------------------------------------------------------------------------------------
using Aspose.Imaging.MicroApps.Merge.Options;
using Aspose.Imaging.MicroApps.Merge.Tasks;
using static Aspose.Imaging.MicroApps.Merge.Options.ImagingMergeOptions;

internal class Runner
{
	static async Task Main(string[] args)
	{
		try
		{
			Console.WriteLine("Hello, World!");
			var options = new ImagingMergeOptions()
			{
				InputImages = "photo_1.jpg+photo_2.jpg+photo_3.jpg+photo_4.jpg+photo_5.jpg+photo_6.jpg".Split("+"),
				ToFormat = "png",
				BackgroundColor = "MediumSeaGreen",
				Direction = MergeDirection.Vertical,
				MarginSize = 3,
				AdjustmentType = MergeAdjustmentTypes.Biggest,
				OutputImagePath = "photo_collage_licensed.png",
				MaxRows = 3,
				MaxColumns = 2,
				MaxWidth = 500,
				VerboseLogging= true
			};

			// You may set path to your Aspose.Imaging .NET license file via parameters
			if (args.Length>0 && File.Exists(args[0]))
			{
				options.LicenseFile = args[0];
			}

			await MergeTasks.Create(options).Execute();
		}
		catch (Exception ex)
		{
			Console.Write(ex.ToString());
			Thread.Sleep(3000);
			throw;
		}
	}
}