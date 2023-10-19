# Aspose.Imaging Micro Apps
Aspose.Imaging Micro Applications supply high-level image processing scenarios useful for end-users.

Work over [Aspose.Imaging .NET API](https://products.aspose.com/imaging/net/).

**Following Micro Applications are supported:**

## Aspose.Imaging Image Merge Micro Application 

It allows creation of collage from several input images in desired image format.

### Competitive features

- Various input and output image formats are supported as per [Aspose.Imaging supported file formats list](https://docs.aspose.com/imaging/net/supported-file-formats/); 

- Various merge layouts are supported (horizontal, vertical, grid);

- Various image adjustments are supported (to the biggest image, to the smallest image, or without adjustment);

- Resulting image may be limited by width, height;

- Setting of margin size and background color are supported;

- We always keep the aspect ratio on merge, so the proportions of your photo are not affected;

- Aspose.Imaging Image merge application may be used via the command line or consumed by your C# code via.NET7 compatible API.

### Licensing

Although Aspose.Imaging Image merge application is free, Aspose.Imaging .NET is licensed as usual, so you may reuse you reuse your
license via application or evaluate the application using Aspose.Imaging .NET in trial mode. 

### System Requirements
-.NET7 or higher compatible OS;
-Aspose.Imaging Image Merge application installed.

### Installation

Please issue the command :

```
dotnet add package Aspose.Imaging.Image-Merge
```

### Usage
**Use from command line :**

```
dotnet Aspose.Imaging.MicroApps.Merge.dll --input photo_1.jpg+photo_2.jpg+photo_3.jpg+photo_4.jpg+photo_5.jpg+photo_6.jpg --output photo_collage_unlicensed.png --format png --adjustment Biggest --direction Vertical --background-color MediumSeaGreen --margin-size 3 --max-columns 2 --max-rows 3 --max-width 500
```

**Use from code:**

``` csharp
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
				MaxWidth = 500
			};

			// You may set path to your Aspose.Imaging .NET license file via parameters
			if (isLicensed)
			{
				options.LicenseFile = "Aspose.Total.Product.Family.lic";
			}

			await MergeTasks.Create(options).Execute();
```

### Examples of output images:

![Example of collage produced by Aspose.Imaging Image merge Apps via command line](assets/images/photo_collage_unlicensed.png)

![Example of collage produced by Aspose.Imaging Image merge Apps from rectangular shapes](assets/images/photo_collage_licensed.png)


