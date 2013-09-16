Photo Rainbow - Organize Your Photos By Color
---------------------------------------------

Photo Rainbow allows the user to sync with an online photo service and organize their photos by color.  Sorting is done by analyzing images by pixel and determining what percentage of pixels are of a color in the visible spectrum.  In short, users can create beautiful presentations of their images showing complete spectrums of memories.  Photo Rainbow will be available as an application for Windows 7.

Users can sort photos in two ways: by brightness and as a rainbow.

## Brightness
The user can choose to view all of the photos of a given color and see those photos organized from the brightest to the least bright.  Sorting is done by any color in the visible spectrum: violet, blue, green, yellow, orange or red.

## Rainbow
The user can also chose to view all their pictures as a rainbow, from violet to red.  Pictures are organized based on the predominant colors present in the image.  This allows the user to see an entire rainbow made up of their photos.

## Flickr
Initially, Photo Rainbow syncs with the Flickr API, with support for additional image hosting services in the future.  

The Flickr API documentation can be found here: http://www.flickr.com/services/api/
The Flickr .NET API Library: http://flickrnet.codeplex.com/
Flickr Photo Source URLs: http://www.flickr.com/services/api/misc.urls.html

## Under the Hood
The architecture utilizes the C# Bitmap library to perform pixel analysis on each image in the collection, identifying the percentage of each color (violet, blue, green, yellow, orange, red) present in an image.  The System.Drawing.Color object also allows us to get the brightness of each color (GetBrightness), which can be used to arrange images of the same group by brightness.
http://msdn.microsoft.com/en-us/library/System.Drawing.Bitmap.aspx

With a color analysis performed on each image, features can be implemented to display the images by color group, or in a spectrum using the percentage value of each color to arrange the images in spectrum order.

Specifically, the system will:
* Integrate with the Flickr API
* Allow for integration with other APIs moving forward
* Get the color information about an image with a response time of no more than 1 second per image and a total response time or no more than 15 seconds for a group of images.
* Cache the image data so as to eliminate the need for processing the same image twice.
* Decouple the image analysis service from the sorting methods.
* Request image files directly from Flickr via HTTP
* Create a user interface to display sorted images.

Visual Studio
-------------
As this is a .NET project, Visual Studio is recommended as an IDE.  Visual Studio Express 2012 can be downloaded [here](http://www.microsoft.com/visualstudio/eng/downloads#d-2012-express)

Documentation
-------------
Documentation can be found at our Google Drive [shared folder](https://drive.google.com/?usp=chrome_app#folders/0By674vD9u1xLQ1IxdGljUEFuMjg).  If you need access to this folder, please let us know.

